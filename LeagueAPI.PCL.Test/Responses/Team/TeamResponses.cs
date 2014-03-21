namespace PortableLeagueAPI.Test.Responses.Team
{
    internal class TeamResponses : Responses
    {
        private TeamResponses() : base("Team") { }

        public static IResponses Instance
        {
            get { return new TeamResponses(); }
        }

        public override string GetFile(string pathAndQuery)
        {
            string response = null;

            if (pathAndQuery.Contains("/team/by-summoner/"))
                response = "TeamBySummoner";
            else if (pathAndQuery.Contains("/team/"))
                response = "TeamByIds";

            return response;
        }
    }
}
