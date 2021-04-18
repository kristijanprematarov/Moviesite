using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moviesite.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moviesite.Service
{
    public class UserService : IUserService
    {
        /// <summary>
        /// Get all existing roles to fillup dropdownlist for RoleId, currentRoleName is optional and can be null, used in UserController--> Edit to get roleID
        /// </summary>
        public IQueryable<SelectListItem> GetSelectListRoles(IQueryable<IdentityRole> roles, string? currentRoleName)
        {
            var selectList = new List<SelectListItem>();

            selectList.Add(new SelectListItem
            {
                Value = "0",
                Text = "Select role...",
                Selected = false
            });

            foreach (var role in roles)
            {
                if (currentRoleName != null)
                {
                    if (role.Name.Equals(currentRoleName))
                    {
                        selectList.Add(new SelectListItem
                        {
                            Value = role.Id,
                            Text = role.Name,
                            Selected = true
                        });
                    }
                    else
                    {
                        selectList.Add(new SelectListItem
                        {
                            Value = role.Id,
                            Text = role.Name,
                            Selected = false
                        });
                    }
                }
                else
                {
                    selectList.Add(new SelectListItem
                    {
                        Value = role.Id,
                        Text = role.Name,
                        Selected = false
                    });
                }
            }

            return selectList.AsQueryable();
        }
    }
}
