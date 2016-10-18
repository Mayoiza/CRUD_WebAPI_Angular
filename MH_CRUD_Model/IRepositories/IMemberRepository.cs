using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MH_CRUD_Model.Models;

namespace MH_CRUD_Model.IRepositories
{
   public interface IMemberRepository
    {
       //Interface for MemberRepository
        
         List<MemberReturn> GetMembers();
         List<MemberReturn> GetProjectMembrs(int id);
       
    }
}
