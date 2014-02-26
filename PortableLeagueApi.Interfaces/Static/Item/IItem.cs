using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Item
{
    public interface IItem : IApiModel
    {
        string Colloq { get; set; }
        bool ConsumeOnFull { get; set; }
        bool Consumed { get; set; }
        int Depth { get; set; }
        string Description { get; set; }
        IList<string> From { get; set; }
        IGold Gold { get; set; }
        string Group { get; set; }
        bool HideFromAll { get; set; }
        IImage Image { get; set; }
        bool InStore { get; set; }
        IList<string> Into { get; set; }
        IDictionary<string, bool> Maps { get; set; }
        string Name { get; set; }
        string Plaintext { get; set; }
        string RequiredChampion { get; set; }
        IMetaData Rune { get; set; }
        int SpecialRecipe { get; set; }
        int Stacks { get; set; }
        IBasicDataStats Stats { get; set; }
        IList<string> Tags { get; set; }
    }
}