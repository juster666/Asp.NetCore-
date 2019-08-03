using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Heavy.Web.ViewModels
{
    public class UserRoleViewModel
    {
        public UserRoleViewModel()
        {
            Users = new List<IdentityUser>();
        }
        [Required]
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public List<IdentityUser> Users { get; set; }
    }
}
