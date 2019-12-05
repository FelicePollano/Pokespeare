using System.Threading.Tasks;
using System.Net.Http;
public class ShakespeareTranslator : IShakespeareTranslator
{
    static readonly HttpClient client = new HttpClient();
    public Task<string> Translate(string source)
    {
        throw new System.NotImplementedException();
    }
}
