﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleLibrary.Filters
{
    [DataContract]
    public class BooleanExpression : Expression
    {
        [DataMember]
        public bool Value { get; set; }
        public BooleanExpression(bool value)
        {
            this.Value = value;
        }

        public static BooleanExpression True = new BooleanExpression(true);
        public static BooleanExpression False = new BooleanExpression(false);
    }
}