namespace PortableLeagueAPI.Test.Responses.League
{
    internal class LeagueResponses : Responses
    {
        private LeagueResponses() : base("League") { }

        public static IResponses Instance
        {
            get { return new LeagueResponses(); }
        }

        public override string GetFile(string pathAndQuery)
        {
            string response = null;

            if (pathAndQuery.Contains("/league/by-summoner/")
                && pathAndQuery.Contains("/entry"))
                response = "BySummonerEntry";
            else if (pathAndQuery.Contains("/league/by-summoner/"))
                response = "BySummoner";
            else if (pathAndQuery.Contains("/league/challenger"))
                response = "Challenger";
            else if (pathAndQuery.Contains("/league/by-team/")
                && pathAndQuery.Contains("/entry"))
                response = "ByTeamEntry";
            else if (pathAndQuery.Contains("/league/by-team/"))
                response = "ByTeam";

            return response;
        }
    }
}
