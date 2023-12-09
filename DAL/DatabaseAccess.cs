using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAL
{
	public static class DatabaseAccess
	{
		// This connection string will change according to people's local machines.
		public static string ConnectionString =
			@"Data Source=ALICE\SQLEXPRESS;Initial Catalog=QUANLIDAILY;Integrated Security=True";

		// Establish a connection, but not yet open it.
		public static SqlConnection Connect()
		{
			var conn = new SqlConnection(ConnectionString);
			return conn;
		}

		// Return the tuple of UserAccount and UserRole if success, otherwise return null.
		public static Tuple<UserAccount, UserRole>? LogIn(string name, string password)
		{
			using var conn = Connect();
			conn.Open();
			using var cmd = conn.CreateCommand();
			cmd.CommandText = @$"
SELECT TOP 1
	ua.UserAccountId,
	ur.UserRoleId,
	ur.UserRoleName
FROM
	UserAccount ua
	JOIN UserRole ur ON ua.UserRoleId = ur.UserRoleId
WHERE
	ua.UserAccountName = N'{name}'
	AND ua.UserAccountPassword = N'{password}'";
			MessageBox.Show(cmd.CommandText);
			using var reader = cmd.ExecuteReader();
			if (reader == null)
			{
				return null;
			}
			if (reader.Read())
			{
				int userAccountId = reader.GetInt32(0);
				int userRoleId = reader.GetInt32(1);
				string userRoleName = reader.GetString(2)!;
				return new (
					new UserAccount(userAccountId, name, password, userRoleId),
					new UserRole(userRoleId, userRoleName));
			}
			return null;
		}
	}
}
