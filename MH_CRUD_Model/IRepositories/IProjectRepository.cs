using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH_CRUD_Model.IRepositories
{
   public interface IProjectRepository
    {
         List<Project> GetProjects();
    }
}
