using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Pokespeare.Common;
namespace TestProviders
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task  TestPokemonProvider()
        {
            var provider = new PokemonInfoProvider();
            var res = await provider.GetDescriptionAsync("charizard");
            Assert.AreNotEqual(-1,res.IndexOf("Charizard flies"));
        }
    }
}
