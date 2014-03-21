namespace PortableLeagueAPI.Test.Responses.Static
{
    internal class StaticResponses : Responses
    {
        private StaticResponses() : base("Static") { }

        public static IResponses Instance
        {
            get { return new StaticResponses(); }
        }

        public override string GetFile(string pathAndQuery)
        {
            string response = null;

            if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/champion/"))
                response = "ChampionById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/champion"))
                response = "Champions";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/item/"))
                response = "ItemById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/item"))
                response = "Items";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/mastery/"))
                response = "MasteryById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/mastery"))
                response = "Masteries";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/realm"))
                response = "Realm";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/rune/"))
                response = "RuneById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/rune"))
                response = "Runes";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/summoner-spell/"))
                response = "SummonerSpellById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains("/v1/summoner-spell"))
                response = "SummonerSpell";

            return response;
        }
    }
}
