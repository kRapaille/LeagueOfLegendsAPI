using System.Threading.Tasks;

namespace PortableLeagueAPI.Test.Responses
{
    public interface IResponses
    {
        Task<string> GetResponse(string pathAndQuery);
        string GetFile(string pathAndQuery);
    }
}