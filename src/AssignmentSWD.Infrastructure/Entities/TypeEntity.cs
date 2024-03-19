using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.Infrastructure.Entities
{
    [Table("Type")]
    public class TypeEntity : Entity
    {
        public string? TypeName { get; set; }
    }
}
