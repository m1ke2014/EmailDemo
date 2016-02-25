using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmailDemo.Models
{
    public class MailerDbContext : DbContext
    {
        public MailerDbContext()
            : base("MailerDb")
        {
        }

        public DbSet<Comment> Comments { get; set; }
    }
}