using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
namespace TestApi
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string TestUri = "http://localhost:5000/pokemon/charizard";
        static readonly string Expected = "flies 'round"; //a not so strcit marker we have the expected Shakespeare reply...
        static async Task Main(string[] args)
        {
            bool launch = true;
            if( args.Length > 0 && args[0]=="--nolaunch")
                launch = false;
            var saveColor = Console.ForegroundColor;
            Process process = null;
            if( launch )
            {
                // run the webapi app
                process = new Process
                {
                    StartInfo =
                    {
                        FileName = "dotnet",
                        Arguments = "run",
                        UseShellExecute = false,
                        WorkingDirectory = "../../src/Pokespeare"
                    }
                };
                await Info("Starting web api application");
                process.Start();
            }

            try{
                
                 
                var httpResponse = await client.GetAsync(TestUri);

                if (!httpResponse.IsSuccessStatusCode)
                {
                    await Error($"Failure: Http error code:{httpResponse.StatusCode}");
                }
                else
                {
                    var response = await httpResponse.Content.ReadAsStringAsync();
                    if(response.IndexOf(Expected) == -1 )
                    {
                        await Error($"reply {response} DOES NOT contain expected'{Expected}'");
                    }
                    
                }
                
            }
            catch(Exception e)
            {
                await Error($"Fatal error:{e.ToString()}");
            }

            if( launch )
            {
                await Info("Killing web api application");
                process.Kill();
            }
            Console.ForegroundColor = saveColor;
        }
        static async Task  Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            await Console.Error.WriteLineAsync(message);
        }    
        static async Task Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            await Console.Error.WriteLineAsync(message);
        }  
              
    }
    
}
