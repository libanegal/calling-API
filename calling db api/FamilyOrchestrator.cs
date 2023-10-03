using calling_db_api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_db_api
{
    public class FamilyOrchestrator
    {
        private readonly IGetMembers _getMembers;
        private readonly IGetaFamily _getaFamily;
        private readonly IGetMember _getMember;

        public FamilyOrchestrator(IGetMembers getMembers, IGetaFamily getaFamily, IGetMember getMember)
        {
            _getMembers = getMembers;
            _getaFamily = getaFamily;
            _getMember = getMember;
        }

        public async Task<List<FamilyMember>> FamilyMembersOrchestor() 
        {
            var member = new GetAmember();
            var getMembers = await _getMembers.GetFamilyMembers();
            var getaFamily = _getaFamily.GetAfamily(getMembers);
            
            var getAmember = await _getMember.GetaMember(await member.getMemberEndpoint());
            return  getMembers; 
        }
    }
}
