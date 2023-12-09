using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class UserAccount
	{
		public int UserAccountId { get; set; }
		public string UserAccountName { get; set; } = "";
		public string UserAccountPassword { get; set; } = "";
		public int UserRoleId { get; set; }

		public UserAccount()
		{
			// Nothing
		}

		public UserAccount(int userAccountId, string userAccountName, string userAccountPassword, int userRoleId)
		{
			UserAccountId = userAccountId;
			UserAccountName = userAccountName;
			UserAccountPassword = userAccountPassword;
			UserRoleId = userRoleId;
		}
	}
}
