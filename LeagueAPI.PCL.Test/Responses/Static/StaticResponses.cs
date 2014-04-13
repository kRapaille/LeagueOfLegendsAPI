namespace PortableLeagueAPI.Test.Responses.Static
{
    internal class StaticResponses : Responses
    {
        private const string Version = "v1.2";

        private StaticResponses() : base("Static") { }

        public static IResponses Instance
        {
            get { return new StaticResponses(); }
        }

        public override string GetFile(string pathAndQuery)
        {
            string response = null;

            if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/champion/", Version)))
                response = "ChampionById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/champion", Version)))
                response = "Champions";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/item/", Version)))
                response = "ItemById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/item", Version)))
                response = "Items";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/mastery/", Version)))
                response = "MasteryById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/mastery", Version)))
                response = "Masteries";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/realm", Version)))
                response = "Realm";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/rune/", Version)))
                response = "RuneById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/rune", Version)))
                response = "Runes";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/summoner-spell/", Version)))
                response = "SummonerSpellById";
            else if (pathAndQuery.Contains("/static-data/")
                && pathAndQuery.Contains(string.Format("/{0}/summoner-spell", Version)))
                response = "SummonerSpell";

            return response;
        }
    }
}
