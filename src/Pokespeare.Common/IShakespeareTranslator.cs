using System.Threading.Tasks;
public interface IShakespeareTranslator
{
    Task<string> Translate(string source);
}