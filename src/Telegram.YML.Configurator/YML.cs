using YamlDotNet.Serialization;

namespace Telegram.YML.Configurator
{
    public class YML
    {
        private readonly string _ymlText;

        public YML(string ymlText)
        {
            _ymlText = ymlText;
        }

        public static implicit operator YMLConfigurationData(YML yml)
        {
            var deserializer = new DeserializerBuilder().Build();
            var yamlObject = deserializer.Deserialize<YMLConfigurationData>(yml._ymlText);

            return yamlObject;
        }
    }
}
