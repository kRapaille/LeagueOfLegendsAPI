namespace PortableLeagueAPI.Test.Responses.Summoner
{
    internal class SummonerResponses : Responses
    {
        private SummonerResponses() : base("Summoner") { }

        public static IResponses Instance
        {
            get { return new SummonerResponses(); }
        }

        public override string GetFile(string pathAndQuery)
        {
            string response = null;

            if (pathAndQuery.Contains("/summoner/")
                && pathAndQuery.Contains("/masteries"))
                response = "SummonerMasteries";
            else if (pathAndQuery.Contains("/summoner/")
                && pathAndQuery.Contains("/runes"))
                response = "SummonerRunes";
            else if (pathAndQuery.Contains("/summoner/by-name/"))
                response = "SummonerByName";
            else if (pathAndQuery.Contains("/summoner/")
                && pathAndQuery.Contains("/name"))
                response = "SummonerName";
            else if (pathAndQuery.Contains("/summoner/"))
                response = "SummonerById";

            return response;
        }
    }
}
