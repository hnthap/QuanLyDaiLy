using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BLL
{
	public static class UserAccountBLL
	{
		public static UserAccount? CurrentAccount { get; set; } = null;
		public static UserRole? CurrentRole { get; set; } = null;
		public static List<UserRight> CurrentRights { get; set; } = new List<UserRight>();

		public static bool TryLogIn(string name, string password)
		{
			name = name.Trim();
			if (string.IsNullOrEmpty(name))
			{
				return false;
			}
			if (string.IsNullOrEmpty(password))
			{
				return false;
			}
			var result = DatabaseAccess.GetUserAccountByNameAndPassword(name, password);
			if (result == null)
			{
				return false;
			}
			(CurrentAccount, CurrentRole) = result;
			CurrentRights = DatabaseAccess.GetUserRightsOfUserRoleIds(CurrentRole.UserRoleId);
			return true;
		}

		public static bool TrySignUp(string name, string email, string password, string confirmedPassword)
		{
			if (password != confirmedPassword)
			{
				MessageBox.Show("The confirmed password is not correct.");
				return false;
			}
			name = name.Trim();
			email = email.Trim();

            if (DatabaseAccess.IsExistingUserAccountName(name))
            {
				MessageBox.Show($"The name {name} has already registed!");
				return false;
            }
			if (DatabaseAccess.IsExistingUserAccountEmail(email))
			{
				MessageBox.Show($"The email {email} has already been used!");
				return false;
			}

            bool result = DatabaseAccess.SignUp(name, email, password);
			return result;
		}
	}
}
