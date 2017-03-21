using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CaptivePortal.API.Models
{
    public class UserRole
    {

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public int id { get; set; }

        public virtual Role Role { get; set; }
    }
}