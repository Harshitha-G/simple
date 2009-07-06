﻿using System;
using System.Collections.Generic;

using System.Text;

namespace Simple.DataAccess
{
    public class PropertyDescriptionMapping
    {
        public string SourceProperty { get; set; }
        public string DestProperty { get; set; }
        public PropertyDescriptionMapping(string source, string dest)
        {
            this.SourceProperty = source;
            this.DestProperty = dest;
        }
    }
}