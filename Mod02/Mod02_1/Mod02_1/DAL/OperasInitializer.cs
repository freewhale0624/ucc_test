using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mod02_1.Models;
using System.Data.Entity;


namespace Mod02_1.DAL
{
    public class OperasInitializer : 
        DropCreateDatabaseAlways<OperaContext>
    {
        protected override void Seed(OperaContext context)
        {
            base.Seed(context);
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart"
            });
            context.SaveChanges();
        }
    }

}