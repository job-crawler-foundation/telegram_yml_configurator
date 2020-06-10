using System;
using System.Collections.Generic;
using System.Text;
using Telegram.YML.Configurator.ConfigurationCommands;

namespace Telegram.YML.Configurator
{
    public class YMLConfigurationData
    {
        public List<SetInlineCommand> InlineCommands { get; set; }
    }
}
