using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelService
{
    public class ApplicationRole : IdentityRole
    {
        public string RoleName { get; set; }
        public string RoleIcon { get; set; }
        public string Handle { get; set; }
        public bool IsActive { get; set; }
        public ICollection<RolePermission> Permissions { get; set; }
    }
}
