using System;
using IO.Swagger.Api;
using IO.Swagger.Client;
using System.IO;
using System.Collections.Generic;

//-authToken ZmM1YjI2Y2UtMjc0Yy00N2EzLThiZWMtZTRlMmZhYTVhYTFj -fpr C:\webinspect\scans\Scan.fpr -applicationVersionID 9 -sscUrl http://localhost:8180/ssc/ 

namespace SSCUploader
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PARAM_FPR = "-fpr";
            const string PARAM_TOKEN = "-sscToken";
            const string PARAM_APP_ID = "-appVersionID";
            const string PARAM_SSC_URL = "-sscUrl";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fortify SSCUploader");

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;

                // Display help
                if (args.Length == 1 && HelpRequired(args[0]))
                {
                    DisplayHelp();
                }

                // hopefully you have even number args count.
                for (int i = 0; i < args.Length; i += 2)
                {
                    {
                        parameters.Add(args[i], args[i + 1]);
                    }
                }

                // Validate params
                if (!parameters.ContainsKey(PARAM_TOKEN))
                {
                    ExitWithError("authToken parameter missing");
                }
                else if (!parameters.ContainsKey(PARAM_SSC_URL))
                {
                    ExitWithError("sscUrl parameter missing");
                }
                else if (!parameters.ContainsKey(PARAM_APP_ID))
                {
                    ExitWithError("applicationVersionID parameter missing");
                }
                else if (!parameters.ContainsKey(PARAM_FPR))
                {
                    ExitWithError("fpr parameter missing");
                }
            }
            catch(Exception paramException)
            {
                ExitWithError("Invalid parameters - " + paramException.Message );
            }

            // Does the FPR exist
            if(!File.Exists(parameters[PARAM_FPR]))
            {
                ExitWithError("FPR not found");
            }

            // Is the SSC Url valid
            if (!Uri.IsWellFormedUriString(parameters[PARAM_SSC_URL], UriKind.Absolute))
            {
                ExitWithError("Invalid SSC Url specified");
            }

            // Show the paramters passed
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\nParameters");
            foreach (var pair in parameters)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
            
            // Now start the import
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nStarting import....");
            

            try
            {
                Configuration.ApiKey.Add("Authorization", "FortifyToken " + parameters[PARAM_TOKEN]);  //Unified Token
                var apiClient = new ApiClient("http://localhost:8180/ssc/api/v1");
                Configuration.DefaultApiClient = apiClient;

                var artifactApi = new ArtifactOfProjectVersionControllerApi(apiClient);
                var stream = new System.IO.FileStream(parameters[PARAM_FPR], FileMode.Open);
                artifactApi.UploadArtifactOfProjectVersion(Convert.ToInt32(parameters[PARAM_APP_ID]), stream, string.Empty);

                Console.WriteLine("\r\nFPR uploaded succesfully");
            }
            catch(Exception sscException)
            {
                ExitWithError(sscException.Message);
            }

            Console.ResetColor();

        }

        private static void DisplayHelp()
        {
            Console.WriteLine("SSCUploader help");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n-fpr: Fully qualified path to the FPR file");
            Console.WriteLine("-authToken: SSC authorization token");
            Console.WriteLine("-applicationVersionID: SSC application Id");
            Console.WriteLine("-sscUrl: SSC url. Example: http://myhost/ssc");
            Console.WriteLine("\r\nExample: SSCUploader.exe -authToken MYAUTHTOKEN -fpr C:\\webinspect\\scans\\Scan.fpr -applicationVersionID 9 -sscUrl http://myhost:8180/ssc/ ");
            Console.ResetColor();
            Environment.Exit(0);
        }

        private static bool HelpRequired(string param)
        {
            return param == "-h" || param == "--help" || param == "/h" || param == "-help" || param == "/?" || param == "-?";
        }

        private static void ExitWithError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\nError: " + message);
            Console.ResetColor();
            Environment.Exit(1);
        }
    }
}
