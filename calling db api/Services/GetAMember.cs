using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_db_api
{
    public class GetAmember
    {

        public async Task<List<FamilyMember>> getMemberEndpoint() 
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage();

            string firstName; Console.WriteLine("Enter the first name of the person you want to retrieve");
            firstName = Console.ReadLine();

            request.RequestUri = new Uri("https://localhost:7019/api/FamilyMembers/Retrieve single member?firstName="+firstName+"");
            var json = await client.SendAsync(request);
            var response =  json.Content.ReadAsStringAsync().Result;
            var memberObject = JsonConvert.DeserializeObject<List<FamilyMember>>(response);
            return memberObject;
        }
    }
}
