using CRM.DOMAIN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DOMAIN.Entities
{
    public class Employee : BaseEntity
    {
        public int UserId { get; set; }
        public string IdentityNumber { get; set; } = null!;
        public int? GenderId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? StatusTypeId { get; set; }
        public int? RegionId { get; set; }
        public DateOnly? BirthDate { get; set; }
        public int? ParentEmployeeId { get; set; }

    }
}
