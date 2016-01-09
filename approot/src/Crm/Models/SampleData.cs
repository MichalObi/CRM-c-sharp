using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Crm.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.myModel.Any())
            {
                context.myModel.AddRange(
                    new myModel()
                    {
                        LastName = "Dama",
                        FirstMidName = "Ania",
                        CompanyName = "NTFS",
                        OpeningYear = 1959,
                        Adress = "Ulica 09",
                        City = "Kostrzyn"
                    },
                    new myModel()
                    {
                        LastName = "Bisz",
                        FirstMidName = "Bartek",
                        CompanyName = "Lorey",
                        OpeningYear = 1953,
                        Adress = "Ulica 13",
                        City = "Warszawa"
                    },
                    new myModel()
                    {
                        LastName = "Malysz",
                        FirstMidName = "Adam",
                        CompanyName = "HIT",
                        OpeningYear = 1950,
                        Adress = "Ulica 12",
                        City = "Milczyn"
                    },
                    new myModel()
                    {
                        LastName = "Talim",
                        FirstMidName = "Kamil",
                        CompanyName = "Tesco",
                        OpeningYear = 1952,
                        Adress = "Ulica 11",
                        City = "Polkowice",
                        Note = "Testowa notatka ze spotkania."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}