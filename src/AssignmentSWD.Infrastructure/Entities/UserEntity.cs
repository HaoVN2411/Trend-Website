using AssignmentSWD.Core.EnumCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.Infrastructure.Entities
{
    [Table("User")]
    public class UserEntity : Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; }
        public string Email { get; set; }
        public string ValidateEmailKey { get; set; }

    }
}
