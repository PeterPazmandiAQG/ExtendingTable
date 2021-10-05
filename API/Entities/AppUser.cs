using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser: IdentityUser<int>
    {
        public string? FirstName { get; set; }
        public string? FullName { get; set; }
        
        [Column("Mail")]
        public override string? Email { get; set; }
        public int PIN { get; set; }
        
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}