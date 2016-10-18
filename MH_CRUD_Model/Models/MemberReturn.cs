using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH_CRUD_Model.Models
{
    public class MemberReturn
    {
        public int ID { get; set; }        
        public string Title { get; set; }
        public string ProjectName { get; set; }
        public int ProjectId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
