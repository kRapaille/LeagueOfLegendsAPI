namespace PortableLeagueAPI.Test.Responses.Stats
{
    internal class StatsResponses : Responses
    {
        private StatsResponses()
            : base("Stats")
        {
        }

        public static IResponses Instance
        {
            get { return new StatsResponses(); }
        }

        public override string GetFile(string pathAndQuery)
        {
            string response = null;

            if (pathAndQuery.Contains("/stats/by-summoner/")
                && pathAndQuery.Contains("/summary"))
                response = "BySummonerSummary";
            else if (pathAndQuery.Contains("/stats/by-summoner/")
                && pathAndQuery.Contains("/ranked"))
                response = "BySummonerRanked";

            return response;
        }
    }
}
