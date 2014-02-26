using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Static.Constants
{
    public class LanguageCodeConsts
    {
        public static readonly Dictionary<LanguageEnum, string> SupportedLanguages = new Dictionary<LanguageEnum, string>
        {
            { LanguageEnum.German ,"de_DE" },
            { LanguageEnum.Greek ,"el_GR" },
            { LanguageEnum.EnglishAU ,"en_AU" },
            { LanguageEnum.EnglishUK ,"en_GB" },
            { LanguageEnum.EnglishUS ,"en_US" },
            { LanguageEnum.SpanishAR ,"es_AR" },
            { LanguageEnum.SpanishES ,"es_ES" },
            { LanguageEnum.SpanishMX ,"es_MX" },
            { LanguageEnum.French ,"fr_FR" },
            { LanguageEnum.Italian ,"it_IT" },
            { LanguageEnum.Korean ,"ko_KR" },
            { LanguageEnum.Polish ,"pl_PL" },
            { LanguageEnum.Portuguese ,"pt_BR" },
            { LanguageEnum.Romanian ,"ro_RO" },
            { LanguageEnum.Russian ,"ru_RU" }
        };
    }
}
