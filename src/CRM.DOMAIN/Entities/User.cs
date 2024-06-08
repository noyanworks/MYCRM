using CRM.DOMAIN.Common;
using CRM.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYCRM.DOMAIN.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public string ActivationKey { get; set; }
        public string IsActive { get; set; }
        public Customer CustomerFk { get; set; }
    }
}
