using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MH_CRUD_Model
{
    public class Project
    {
        //PK Identity field 
        [Key]
        public int Id { get; set; }
        //Project Name field    
        [Required]
        public string ProjectName { get; set; }
        //Creation Date Field
        public DateTime CreateDate { get; set; }
        //Start Date Field
        public DateTime StartDate { get; set; }
        //End date field
        public DateTime EndDate { get; set; }
        //Navigation Property
        public ICollection<Member> Members { get; set; }

        //Here we are considering a One - Many relationship between a Project
        //and Members table (assuming a Project can have multiple Members).
        //So the Project model is having a navigation property which is a collection 
        //and refers to the Members. 
    }
}
