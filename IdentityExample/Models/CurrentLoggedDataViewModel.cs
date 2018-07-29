using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityExample.Models
{
    public class CurrentLoggedDataViewModel
    {
		public string UserName { get; set; }

		public string[] RoleNames { get; set; }
    }
}
