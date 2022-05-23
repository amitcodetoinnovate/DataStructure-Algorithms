
using System.Collections.Generic;

using System.IO;

using System.Net;
using Newtonsoft.Json.Linq;

namespace CodingProblems.GFG
{
    public class APIII
    {
        private static string url = @"https://raw.githubusercontent.com/arcjsonapi/ApiSampleData/master/api/users";
        public static List<int> apiResponseParser(List<string> inputList, int size)
        {
            
            string[] searchFields = inputList[0].Split('.');
            string operatorType = inputList[1];
            string[] searchValues = inputList[2].Split(',');

            string rawResponse = GetRawResponse();
            JArray parsedResponseArray = JArray.Parse(rawResponse);
            
            GetFilteredData(searchFields, operatorType,parsedResponseArray);



            return null;
        }

        private static void GetFilteredData(string[] seachFields, string operatorType,JArray response)
        {
            if (seachFields.Length > 1)
            {
                foreach (var item in response)
                {
                    var root = item.Value<double?>("width");
                    if (root != null)
                    {

                    }
                }
            }
            else
            {

            }
        }

        public static string GetRawResponse()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
