using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MH_CRUD_Model;
using MH_CRUD_Model.IRepositories;
using MH_CRUD_WebAPI.Models;
using MH_CRUD_WebAPI;
using MH_CRUD_Model.Models;

namespace MH_CRUD_WebAPI.Repositories
{
    //Repository Class to deal with the Retrieve functions of the database
    public class MemberRepository:IMemberRepository
    {


        //Get All members
        public List<MemberReturn> GetMembers()
        {

            using (MH_CRUDContext db = new MH_CRUDContext())
            {

                var allData = from m in db.Members
                              join p in db.Projects on m.ProjectId equals p.Id
                              select new MemberReturn
                              {
                                  ID = m.Id,
                                  FirstName = m.FirstName,
                                  LastName = m.LastName,
                                  Title = m.Title,
                                  ProjectName = p.ProjectName,
                                  ProjectId = m.ProjectId
                              };

                return allData.ToList();

            }
        }
        //--------Get members by Project ID
        public List<MemberReturn> GetProjectMembrs(int id)
        {
            using (MH_CRUDContext db = new MH_CRUDContext())
            {
                var members = from m in db.Members
                              join p in db.Projects on m.ProjectId equals p.Id
                              where p.Id == id
                              select new MemberReturn
                              {
                                  ID = m.Id,
                                  FirstName = m.FirstName,
                                  LastName = m.LastName,
                                  Title = m.Title,
                                  ProjectName = p.ProjectName,
                                  ProjectId = m.ProjectId

                              };


                return members.ToList();
            }
        }





//We preferred not to build the Post, Put, and Delete functions at the repository class and build them at the controller directly
        //P.S. You may found that the repository design pattern here is not so useful and this is because the project is very limited 
        //and small.

        
       
    }
}