using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_db_api
{
    public class GetaFamily:IGetaFamily
    {
        public async Task<List<FamilyMember>> GetAfamily(List<FamilyMember> memberObject ) 
        {
            string secondName;Console.WriteLine("Enter the second name of the family you want to retrieve");
            secondName = Console.ReadLine();

            var family = memberObject.Where(m=> m.secondName == secondName);
            
            return (List<FamilyMember>)family;

        }
    }
}
