using calling_db_api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_db_api.Controllers
{
    public class GetMember:IGetMember
    {
        public async Task<List<FamilyMember>> GetaMember(List<FamilyMember> member) 
        {
            
            return  member;
        }
    }
}
