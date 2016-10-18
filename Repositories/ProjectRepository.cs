using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MH_CRUD_Model;
using MH_CRUD_Model.IRepositories;
using MH_CRUD_WebAPI.Models;
using MH_CRUD_WebAPI;

namespace MH_CRUD_WebAPI.Repositories
{
    public class ProjectRepository:IProjectRepository
    {
        //-----Return all the Projects--
        public List<Project> GetProjects()
        {
            using(MH_CRUDContext db = new MH_CRUDContext())
            {
                return db.Projects.ToList();
            }
        }
    }
}