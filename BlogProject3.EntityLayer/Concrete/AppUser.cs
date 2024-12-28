using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>     //Aşağıdaki proplar zaten ekleniyor.Id'yi yazmadık int e çevirdik bu satırda
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }

        public List<Article> Articles { get; set; }
    }
}
