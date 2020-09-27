using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using DataAPIClientExample;
using DataAPIClientExample.Models;
using Microsoft.Rest;
using Newtonsoft.Json;
using NRApiClient.Helpers;
using NRApiClient.Models;

namespace DataAPIClientExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string server, projectId, username, password;
            if (args == null || args.Length < 4)
            {
                Console.WriteLine("Missing arguments.");
                return;
            }
            else
            {
                server = args[0];
                projectId = args[1];
                username = args[2];
                password = args[3];
            }

            Console.WriteLine("----------------------NR CSV to API----------------------");
            Console.WriteLine("Authenticating...");

            DataAPIClient apiClient = new DataAPIClient(new System.Net.Http.HttpClient(), true)
            {
                BaseUri = new Uri(server)
            };

            apiClient.HttpClient.Timeout = Timeout.InfiniteTimeSpan;

            //authorize
            TokenResponse tokenResponse = AccountExtensions.GetToken(apiClient.Account, new TokenRequest(username, password));
            apiClient.HttpClient.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", tokenResponse.AccessToken);
            if (tokenResponse.AccessToken == null || tokenResponse.AccessToken == "")
            {
                Console.WriteLine("AUTHENTICATION FAILED");
                return;
            }
            else
            {
                Console.WriteLine("Authentication COMPLETED!");
            }

            Console.WriteLine("Mapping data from CSV...");

            string filelocation = Path.Combine(Environment.CurrentDirectory + "\\..\\..\\Data\\csv\\test.csv");
            
            //Mapping CSV data into C# object
            List<CSVData> csvData = DataMapper.getMappedDataFromCSV(filelocation);

            JSONModel uploadData = new JSONModel();
            //Mapping MetaData for JSONModel
            DataMapper.getMetadataForImport().ForEach(uploadData.MetaData.Add);
            //Mapping CaseData for JSONModel
            DataMapper.getCasedataForImport(csvData).ForEach(uploadData.CaseData.Add);
            //Serializing JSONModel C# Object to JSON Object
            var json = new JavaScriptSerializer().Serialize(uploadData);
            Console.WriteLine("Mapping COMPLETED!");

            //Import API of JSON Object data
            Console.WriteLine("Importing data to the server");
            dynamic importInput = json;
            Response importResponse = ImportExtensions.PostImport(apiClient.Import, importInput, projectId);
            if (importResponse.Data == null || tokenResponse.AccessToken == "")
            {
                Console.WriteLine("DATA IMPORT FAILED");
                return;
            }
            else
            {
                Console.WriteLine("Import COMPLETED!");
            }

            //GET Import Batches API
            PagedInputOfBatchFilterInput batchFilterInput = new PagedInputOfBatchFilterInput()
            {
                Paging = new PagingInput()
                {
                    PageNumber = 1,
                    PageSize = 10
                }
            };
            Response batches = ImportExtensions.Batches(apiClient.Import, batchFilterInput, projectId);

            //Isolating ImportId for activation from batches.Data string
            var Ids = batches.Data.ToString();
            Ids = Ids.Substring(Ids.IndexOf("ImportID") + 11, Ids.Length - (Ids.IndexOf("ImportID") + 11));
            Ids = Ids.Substring(0, Ids.IndexOf("\r") - 1);
            string[] parsedIds = Ids.Split(',');
            List<long?> IdsToActivates = new List<long?>();
            foreach (string s in parsedIds)
            {
                if (Int32.TryParse(s, out int result))
                {
                    IdsToActivates.Add(result);
                }
            }

            Console.WriteLine("Activating data on the server...");

            //Activate Import Batches API
            ActivateInput activateInput = new ActivateInput()
            {
                IdsToActivate = IdsToActivates,
                IdsToDeactivate = new List<long?>()
            };
            ActivationExtensions.Activate(apiClient.Activation, activateInput, projectId);

            //GET Activation History API
            PagedInputOfActivationHistoryFilterInput historyFilterInput = new PagedInputOfActivationHistoryFilterInput()
            {
                Paging = new PagingInput()
                {
                    PageNumber = 1,
                    PageSize = 10
                }
                ,
                Sorting = new SortingInput()
                {
                    OrderBy = "ActivationTime",
                    Ascending = false
                }
            };
            Response activationHistory = ActivationExtensions.History(apiClient.Activation, historyFilterInput, projectId);

            //Isolating last history record for valdiation
            var history = activationHistory.Data.ToString();
            history = history.Substring(history.IndexOf("ActivationTime") + 18, history.Length - (history.IndexOf("ActivationTime") + 18));
            history = history.Substring(0, history.IndexOf("\r") - 3);
            if (DateTime.TryParse(history,out DateTime lastHistory))
            {
                if (lastHistory > DateTime.Now.AddMinutes(-60))
                {
                    Console.WriteLine("Data activation COMPLETED!");
                }
                else
                {
                    Console.WriteLine("DATA ACTIVATION FAILED");
                    return;
                }
            }
            else
            {
                Console.WriteLine("DATA ACTIVATION FAILED");
                return;
            }
        }
    }
}
