using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace openlayerAPI.Localization
{
    public static class openlayerAPILocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(openlayerAPIConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(openlayerAPILocalizationConfigurer).GetAssembly(),
                        "openlayerAPI.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
