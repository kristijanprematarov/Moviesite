using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Moviesite.Areas.Identity
{
    public class UserModel
    {
        [Key]
        public string ID { get; set; }

        [Required(ErrorMessage = "Please enter username !")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the email of the user !")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        public IQueryable<SelectListItem> Roles { get; set; }

        public string RoleId { get; set; }

        public string RoleName { get; set; }

    }
}
