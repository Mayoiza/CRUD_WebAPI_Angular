﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MH_CRUD_Model;


namespace MH_CRUD_WebAPI.Models
{
    public class MH_CRUDContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        //name=
        public MH_CRUDContext()
            : base("MH_CRUDContext")
        {
        }

        public System.Data.Entity.DbSet<Project> Projects { get; set; }

        public System.Data.Entity.DbSet<Member> Members { get; set; }
    
    }
}
