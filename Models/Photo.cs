using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace coreApp.Models
{
    public class PhotoContext: DbContext
    {
        public PhotoContext(DbContextOptions<PhotoContext> options): base(options)
        {
            
        }

        public DbSet<Photo> Photos {get; set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
    }
    public class Photo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PhotoId { get; set;}

        public string Src { get; set;}

        public int Likes { get; set;}

        public int UserId { get; set;}
    }

    public class User {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Address> Address { get; set; }

    }

    public class Address {
        public int AddressId { get; set; }
        public City City { get; set; }
        public int Region { get; set; }
        public Country Country { get; set; }
    }

    public class Country {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }

    public class City {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }

}