using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OryxAfrica.Models;
//using OryxWeb.Models;

namespace OryxAfrica.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       // public DbSet<OryxWeb.Models.Part> Part { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Solution> Solutions { get; set; }
//<<<<<<< HEAD
//<<<<<<< HEAD
        public DbSet<Partner> Partner { get; set; }
//=======
//        public DbSet<OryxAfrica.Models.Partner> Partner { get; set; }
//>>>>>>> 456ac9603ae0d11ffb8645b90605c6e2d577cf5c
//=======
        //public DbSet<OryxAfrica.Models.Partner> Partner { get; set; }
//>>>>>>> 456ac9603ae0d11ffb8645b90605c6e2d577cf5c
    }
}

