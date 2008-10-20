﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;
using SimpleLibrary.Config;

namespace SimpleLibrary.ServiceModel
{
    public interface IEndpointConfigurator
    {
        void Configure(ServiceEndpoint endpoint, ConfiguratorElement config);
    }
}