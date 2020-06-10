using System.Threading.Tasks;

namespace Telegram.YML.Configurator.ConfigurationCommands
{
    public interface IConfigurable
    {
        Task Configure(string telegramToken);
    }
}
