﻿using System;
using System.Xml;
using System.Collections.Generic;
namespace Simple.Configuration2
{
    public interface IConfigElement
    {
        string DefaultXmlString { get; }
        void InvokeExpire();
        void LoadFromElement(IConfigElement element);
        void LoadFromElement(XmlElement element);
        void Lock();
        void NotifyLoad(string elementName);
        event EventHandler OnExpire;
        IList<XmlElement> XmlElements { get; set; }
    }
}