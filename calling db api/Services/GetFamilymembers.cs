using calling_db_api.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace calling_db_api
{
    public  class GetFamilymembers:IGetMembers
    {
      

        public async Task<List<FamilyMember>> GetFamilyMembers()

        {
            var _HttpClient = new HttpClient();
            var requestMessage = new HttpRequestMessage();
           
            requestMessage.RequestUri = new Uri("https://localhost:7019/api/FamilyMembers/Get all family members");
            var json = await _HttpClient.SendAsync(requestMessage);
            var response = await json.Content.ReadAsStringAsync();
            var memberObject = JsonConvert.DeserializeObject<List<FamilyMember>>(response);
            return memberObject;

        }
    }
}
