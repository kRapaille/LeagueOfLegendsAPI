namespace PortableLeagueAPI.Test.Responses.Game
{
    internal class GameResponses : Responses
    {
        private GameResponses() : base("Game") { }

        public static IResponses Instance
        {
            get { return new GameResponses(); }
        }

        public override string GetFile(string pathAndQuery)
        {
            string response = null;

            if (pathAndQuery.Contains("/game/by-summoner/"))
                response = "BySummoner";

            return response;
        }
    }
}
