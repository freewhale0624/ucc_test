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
            context.Operas.Add(new Opera
            {
                Title = "Rigoletto",
                Year = 1851,
                Composer = "Giuseppe Verdi",
            });

            context.Operas.Add(new Opera
            {
                Title = "Nixon in China",
                Year = 1987,
                Composer = "John Adams"
            });

            context.Operas.Add(new Opera
            {
                Title = "Wozzeck",
                Year = 1922,
                Composer = "Alban Berg"
            });



            context.SaveChanges();
        }
    }

}