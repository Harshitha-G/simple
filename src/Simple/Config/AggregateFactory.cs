﻿using System;
using System.Collections.Generic;
using Simple.Common;
using Simple.Patterns;
using log4net;
using Simple.Threading;

namespace Simple.Config
{
    /// <summary>
    /// Base class for config based factories.
    /// </summary>
    /// <typeparam name="THIS">The class itself (for static inheritance purposes).</typeparam>
    public class AggregateFactory<THIS> : MarshalByRefObject
        where THIS : AggregateFactory<THIS>, new()
    {
        protected AggregateFactory()
        {
        }

        /// <summary>
        /// The initialized configuration key object.
        /// </summary>
        public object ConfigKey { get; private set; }


        protected object BestKeyOf(params object[] keys)
        {
            return SourceManager.Do.BestKeyOf(keys);
        }

        static Dictionary<object, THIS> _instances = new Dictionary<object, THIS>();
        
        static object contextKey = new object();
        protected static object DefaultKey
        {
            get { return SimpleContext.Data.Get<object>(contextKey); }
            set { SimpleContext.Data.Set(contextKey, value); }
        }

        public static IDisposable KeyContext(object newKey)
        {
            ILog logger = Simply.Do.Log<THIS>();
            logger.InfoFormat("Entering: '{0}.{1}'...", typeof(THIS).Name, newKey ?? "$default");
            var oldKey = DefaultKey;
            DefaultKey = newKey;
            return new DisposableAction(() =>
            {
                logger.InfoFormat("Exiting: '{0}.{1}'...", typeof(THIS).Name, newKey ?? "$default");
                DefaultKey = oldKey;
            });
        }


        /// <summary>
        /// Singleton instance accessor.
        /// </summary>
        public static THIS Do
        {
            get
            {
                return Get(DefaultKey);
            }
        }

        /// <summary>
        /// Projects the factory into another configuration key.
        /// </summary>
        public THIS this[object key]
        {
            get { return Get(key); }
        }

        /// <summary>
        /// Gets an specific keyed configuration.
        /// </summary>
        /// <param name="key">The configuration key object.</param>
        /// <returns>An instance of the factory.</returns>
        public static THIS Get(object key)
        {
            lock (_instances)
            {
                if (key == null) key = SourceManager.Do.DefaultKey;

                THIS ret;
                if (!_instances.TryGetValue(key, out ret))
                {
                    ret = new THIS();
                    ret.ConfigKey = key;
                    _instances[key] = ret;
                }
                return ret;
            }
        }
    }
}
