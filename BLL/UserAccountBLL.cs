using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public static class UserAccountBLL
	{
		public static UserAccount? CurrentAccount { get; set; } = null;
		public static UserRole? CurrentRole { get; set; } = null;

		public static bool TryLogIn(string name, string password)
		{
			if (string.IsNullOrEmpty(name))
			{
				return false;
			}
			if (string.IsNullOrEmpty(password))
			{
				return false;
			}
			var result = DatabaseAccess.LogIn(name, password);
			if (result == null)
			{
				return false;
			}
			(CurrentAccount, CurrentRole) = result;
			return true;
		}
	}
}
