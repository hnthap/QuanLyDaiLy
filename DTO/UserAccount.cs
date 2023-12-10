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
		public string UserAccountName { get; set; } = string.Empty;
		public string UserAccountEmail { get; set; } = string.Empty;
		public string UserAccountPassword { get; set; } = string.Empty;
		public int UserRoleId { get; set; }

		public UserAccount()
		{
			// Nothing
		}

		public UserAccount(
			int userAccountId, string userAccountName, string userAccountEmail,
			string userAccountPassword, int userRoleId)
		{
			UserAccountId = userAccountId;
			UserAccountName = userAccountName;
			UserAccountEmail = userAccountEmail;
			UserAccountPassword = userAccountPassword;
			UserRoleId = userRoleId;
		}
	}
}
