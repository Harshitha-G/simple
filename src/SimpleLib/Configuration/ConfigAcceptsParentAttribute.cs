﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.Configuration2
{
    [global::System.AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public sealed class ConfigAcceptsParentAttribute : NamedAttribute
    {
        public ConfigAcceptsParentAttribute(string name) : base(name) { }
    }
}