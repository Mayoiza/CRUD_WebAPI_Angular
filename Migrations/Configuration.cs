namespace MH_CRUD_WebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MH_CRUD_Model;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<MH_CRUD_WebAPI.Models.MH_CRUDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MH_CRUD_WebAPI.Models.MH_CRUDContext context)
        {
            //  This method will be called after migrating to the latest version.

            //context.Projects.AddOrUpdate(p => p.Id,
            //    new Project()
            //    {
            //        ProjectName = "CRM Application",
            //        CreateDate = new DateTime(2016, 2, 2),
            //        StartDate = new DateTime(2016, 2, 2),
            //        EndDate = new DateTime(2016, 2, 2)
            //    },

            //new Project()
            //{
            //    ProjectName = "ERP Application",
            //    CreateDate = new DateTime(2016, 2, 2),
            //    StartDate = new DateTime(2016, 2, 2),
            //    EndDate = new DateTime(2016, 2, 2)
            //},

            //new Project()
            //{
            //    ProjectName = "Evaluation Application",
            //    CreateDate = new DateTime(2016, 2, 2),
            //    StartDate = new DateTime(2016, 2, 2),
            //    EndDate = new DateTime(2016, 2, 2)
            //},

            //new Project()
            //{
            //    ProjectName = "User Assistant Application",
            //    CreateDate = new DateTime(2016, 2, 2),
            //    StartDate = new DateTime(2016, 2, 2),
            //    EndDate = new DateTime(2016, 2, 2)
            //}

            //     );

            ////-----Members----
            //context.Members.AddOrUpdate(m => m.Id,
                
            //new Member(){FirstName="Mai",LastName="Hassan",Title="Software Developer",ProjectId=3},
            //new Member(){FirstName="Karim",LastName="Zaki",Title="Software Developer",ProjectId=1},
            //new Member(){FirstName="Islam",LastName="Mohamed",Title="Software Developer",ProjectId=3},
            //new Member(){FirstName="Malika",LastName="Karim",Title="Software Developer",ProjectId=2},
            //new Member(){FirstName="Ahmed",LastName="Mostafa",Title="Software Developer",ProjectId=2},
            //new Member(){FirstName="Malek",LastName="Ibrahim",Title="Software Developer",ProjectId=1},
            //new Member(){FirstName="Ali",LastName="Ahmed",Title="Software Developer",ProjectId=4}
            //);




            var projects = new List<Project>
            {
            new Project(){ProjectName="CRM Application",CreateDate= new DateTime(2016,2,2),
            StartDate=new DateTime(2016,2,2),EndDate=new DateTime(2016,2,2)},

            new Project(){ProjectName="ERP Application",CreateDate= new DateTime(2016,2,2),
            StartDate=new DateTime(2016,2,2),EndDate=new DateTime(2016,2,2)},

            new Project(){ProjectName="Evaluation Application",CreateDate= new DateTime(2016,2,2),
            StartDate=new DateTime(2016,2,2),EndDate=new DateTime(2016,2,2)},

            new Project(){ProjectName="User Assistant Application",CreateDate= new DateTime(2016,2,2),
            StartDate=new DateTime(2016,2,2),EndDate=new DateTime(2016,2,2)}
            };
            //Lambda expression to add the list pf projects to the database
            projects.ForEach(p => context.Projects.Add(p));
            context.SaveChanges();

            var members = new List<Member>
            {
            new Member(){FirstName="Mai",LastName="Hassan",Title="Software Developer",ProjectId=3},
            new Member(){FirstName="Karim",LastName="Zaki",Title="Software Developer",ProjectId=1},
            new Member(){FirstName="Islam",LastName="Mohamed",Title="Software Developer",ProjectId=3},
            new Member(){FirstName="Malika",LastName="Karim",Title="Software Developer",ProjectId=2},
            new Member(){FirstName="Ahmed",LastName="Mostafa",Title="Software Developer",ProjectId=2},
            new Member(){FirstName="Malek",LastName="Ibrahim",Title="Software Developer",ProjectId=1},
            new Member(){FirstName="Ali",LastName="Ahmed",Title="Software Developer",ProjectId=4},
            };
            //Lambda Expression to add list of members to the data base
            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
            


        }
    }
}
