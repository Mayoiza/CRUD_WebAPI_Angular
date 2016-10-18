using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MH_CRUD_Model
{
  public class Member
    {
        [Key]
        public int Id { get; set; }

        //FK Field 
        public int ProjectId { get; set; }
        //Member name field 
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Title field
        public string Title { get; set; }
  
        //Navigation Property
        public Project Project { get; set; }
    }
}
