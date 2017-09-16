using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Mod02_1.Models;

namespace Mod02_1.DAL
{
    public class OperaContext : DbContext
    {
        public DbSet<Opera> Operas { get; set; }
    }
}