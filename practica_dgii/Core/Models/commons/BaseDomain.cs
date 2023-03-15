using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.commons
{
    public class BaseDomain
    {
        public int Id { get; set; }

        public bool activo { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public bool DeletedRecord { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

    }
}
