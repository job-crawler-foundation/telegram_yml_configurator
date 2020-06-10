using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.YML.Configurator.ConfigurationCommands
{
    public class SetInlineCommand : IConfigurable
    {
        public string Command { get; set; }

        public string Description { get; set; }

        public Task Configure(string telegramToken)
        {
            throw new NotImplementedException();
        }
    }
}
