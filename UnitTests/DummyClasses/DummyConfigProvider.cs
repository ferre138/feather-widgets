﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Sitefinity.Configuration.Data;

namespace UnitTests.DummyClasses
{
       /// <summary>
    /// This class represents dummy implementation of <see cref="Telerik.Sitefinity.Configuration.Data.XmlConfigProvider"/> used for test purposes only.
    /// </summary>
    public class DummyConfigProvider : XmlConfigProvider
    {
        /// <inheritdoc />
        protected override void Initialize(string providerName, System.Collections.Specialized.NameValueCollection config, Type managerType)
        {
        }

        /// <inheritdoc />
        public override bool LoadSection(Telerik.Sitefinity.Configuration.ConfigSection section, Telerik.Sitefinity.Configuration.ConfigPolicyHandler policyHandler, string policyName)
        {
            return true;
        }

        /// <inheritdoc />
        public override void SaveSection(Telerik.Sitefinity.Configuration.ConfigSection section)
        {
        }
    }
}
