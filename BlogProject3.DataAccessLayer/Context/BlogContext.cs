using BlogProject3.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.DataAccessLayer.Context                      //Temel CRUD işlemleri gerçekleştirilir.
{                                                                   //Entity e özgü metotlar yazılır.
    public class BlogContext :IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; initial catalog=BlogProject3; integrated security=true");
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
    }
}
