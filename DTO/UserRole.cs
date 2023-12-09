﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class UserRole
	{
		public int UserRoleId { get; set; }
		public string UserRoleName { get; set; } = "";

		public UserRole()
		{
			// Nothing
		}

		public UserRole(int userRoleId, string userRoleName)
		{
			UserRoleId = userRoleId;
			UserRoleName = userRoleName;
		}
	}
}
