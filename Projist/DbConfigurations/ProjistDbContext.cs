using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MySql.Data.Entity;
using Projist.Models.DbModels;

namespace Projist.DbConfigurations
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ProjistDbContext : DbContext
    {
        public ProjistDbContext():base("ProjistConn")
        {

        }

        public virtual DbSet<User> Users { get; set; }
    }
}