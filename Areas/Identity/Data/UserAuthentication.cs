using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NefsalienProject.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the UserAuthentication class
    public class UserAuthentication : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public int FirstName { get; set; }
        
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public int LastName { get; set; }
    }
}
