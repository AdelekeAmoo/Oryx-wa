using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OryxAfrica.Models;
using OryxAfrica.Models;

namespace OryxAfrica.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            //if (context.Students.Any())
            //{
            //    return;   // DB has been seeded
            //}

            var clients = new Client[]
            {
                new Client { ClientName = "Dkt",   ClientDesc = "Alexander",
                    },
                new Client { ClientName = "Meredith", ClientDesc = "Alonso",
                    },
                new Client { ClientName = "Arturo",   ClientDesc = "Anand",
                     },
                new Client { ClientName = "Gytis",    ClientDesc = "Barzdukas",
                    },

            };

            foreach (Client s in clients)
            {
                context.Clients.Add(s);
            }
            context.SaveChanges();

            var career = new Career[]
            {
                new Career { Name = "Software Developer",   Description = "Alexander",
                    },
                new Career { Name = "Sales and Marketing", Description = "Alonso",
                    },
                new Career { Name = "Accountant",   Description = "Anand",
                     },
                new Career { Name = "HR",    Description = "Barzdukas",
                    },

            };

            foreach (Career i in career)
            {
                context.Careers.Add(i);
            }
            context.SaveChanges();

            var solutions = new Solution[]
            {

                new Solution { Name = "Payroll",   Details = "Alexander", Link="hello world"
                    },
                new Solution {Name = "SAP",   Details = "Alexander", Link="hello world"
                    },
                new Solution { Name = "HR",   Details = "Alexander", Link="hello world"
                     },
                new Solution {Name = "AIT",   Details = "Alexander", Link="hello world"
                    },
            };

            foreach (Solution d in solutions)
            {
                context.Solutions.Add(d);
            }
            context.SaveChanges();

            //var partner = new Partner[]
            //{
            //    new Partner { Name = "Sapetrol",   Details = "Alexander"
            //        },
            //    new Partner {Name = "Microsoft",   Details = "Alexander"
            //        },
            //    new Partner { Name = "Odoo",   Details = "Alexander"
            //         },
            //    new Partner {Name = "Sage",   Details = "Alexander",
            //        },
            //};

            //foreach (Partner c in partner)
            //{
            //    context.Partners.Add(c);
            //}
            //context.SaveChanges();


        }
    }
}
