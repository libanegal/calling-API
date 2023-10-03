using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_db_api
{
    public interface IGetaFamily
    {
        Task<List<FamilyMember>> GetAfamily(List<FamilyMember> memberObject);
    }
}
