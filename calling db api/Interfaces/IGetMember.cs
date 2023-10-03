using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_db_api.Interfaces
{
    public interface IGetMember
    {
        Task<List<FamilyMember>> GetaMember(List<FamilyMember> member);
    }
}
