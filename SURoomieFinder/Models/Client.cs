using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SURoomieFinder.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Age { get; set; }
        public string Major { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }

        public Questions QuestionList = new Questions();
    }

    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}