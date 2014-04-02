namespace PortableLeagueAPI.Test.Responses.Champion
{
    internal class ChampionResponses : Responses
    {
        private ChampionResponses() : base("Champion") {}

        public static IResponses Instance
        {
            get { return new ChampionResponses(); }
        }

        public override string GetFile(string pathAndQuery)
        {
            string response = null;

            if (pathAndQuery.Contains("champion/?freetoplay=true"))
                response = "FreeChampions";
            else if (pathAndQuery.Contains("champion/?"))
                response = "Champions";
            else if (pathAndQuery.Contains("champion/")
                && !pathAndQuery.Contains("/static-data/"))
                response = "ChampionById";

            return response;
        }
    }
}
