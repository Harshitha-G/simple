﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simple.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Database {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Database() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Simple.Tests.Database", typeof(Database).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Databases&gt;
        ///  &lt;!-- Used  by unit tests. Change to your own databases. They must not be empty, but it is recommended. --&gt;
        ///  
        ///  &lt;Entry Provider=&quot;System.Data.SqlClient&quot; 
        ///         ConnectionString=&quot;server=.\sqlexpress; initial catalog=simple; integrated security=sspi&quot;/&gt;
        ///  
        ///  &lt;Entry Provider=&quot;Oracle.DataAccess.Client&quot;
        ///         ConnectionString=&quot;Data Source=xe;User Id=simple;Password=simple; Pooling=false;&quot;/&gt;
        ///		 
        ///  &lt;Entry Provider=&quot;System.Data.OracleClient&quot;
        ///         ConnectionString=&quot;Data Source=xe;User [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Databases {
            get {
                return ResourceManager.GetString("Databases", resourceCulture);
            }
        }
        
        internal static byte[] Northwind {
            get {
                object obj = ResourceManager.GetObject("Northwind", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
