using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace DAL
{
	public static class DatabaseAccess
	{
		public static string DataSource = @"ALICE\SQLEXPRESS";

		// This connection string will change according to people's local machines.
		public static string ConnectionString =
			$@"Data Source={DataSource};Initial Catalog=QUANLIDAILY;Integrated Security=True";

		// Establish a connection, but not yet open it.
		public static SqlConnection Connect()
		{
			var conn = new SqlConnection(ConnectionString);
			return conn;
		}

		// Return the tuple of UserAccount and UserRole if success, otherwise return null.
		public static Tuple<UserAccount, UserRole>? GetUserAccountByNameAndPassword(
			string name, string password)
		{
			using var conn = Connect();
			conn.Open();
			using var cmd = conn.CreateCommand();
			cmd.CommandText = @$"
SELECT TOP 1
	ua.UserAccountId,
	ua.UserAccountEmail,
	ur.UserRoleId,
	ur.UserRoleName
FROM
	UserAccount ua
	JOIN UserRole ur ON ua.UserRoleId = ur.UserRoleId
WHERE
	ua.UserAccountName = N'{name}'
	AND ua.UserAccountPassword = N'{password}'";
			using var reader = cmd.ExecuteReader();
			if (reader == null)
			{
				return null;
			}
			if (reader.Read())
			{
				int userAccountId = reader.GetInt32(0);
				string userAccountEmail = reader.GetString(1);
				int userRoleId = reader.GetInt32(2);
				string userRoleName = reader.GetString(3);
				return new (
					new UserAccount(userAccountId, name, userAccountEmail, password, userRoleId),
					new UserRole(userRoleId, userRoleName));
			}
			return null;
		}

		public static bool SignUp(string name, string email, string password)
		{
			using var conn = Connect();
			conn.Open();
			using var cmd = conn.CreateCommand();
			int? nextId = GetNextId("USERACCOUNT");
			if (nextId == null)
			{
				return false;
			}
			cmd.CommandText = $@"
INSERT INTO
	USERACCOUNT (
		UserAccountId, UserAccountName, UserAccountEmail,
		UserAccountPassword, UserRoleId)
VALUES
	({nextId}, N'{name}', N'{email}', N'{password}', 10)";
			int result = cmd.ExecuteNonQuery();
			if (result == 0)
			{
				return false;
			}
			return true;
		}

		public static List<UserRight> GetUserRightsOfUserRoleIds(int userRoleId)
		{
			using var conn = Connect();
			conn.Open();
			using var cmd = conn.CreateCommand();
			cmd.CommandText = $@"
SELECT
	urt.UserRightId,
	urt.UserRightName
FROM
	UserRight urt
	JOIN UserRoleDetail urd ON urt.UserRightId = urd.UserRightId
WHERE
	urd.UserRoleId = {userRoleId}";
			using var reader = cmd.ExecuteReader();
			var rights = new List<UserRight>();
			if (reader == null)
			{
				return rights;
			}
			while (reader.Read())
			{
				int userRightId = reader.GetInt32(0);
				string userRightName = reader.GetString(1);
				rights.Add(new UserRight(userRightId, userRightName));
			}
			return rights;
		}

		public static bool IsExistingUserAccountName(string name)
		{
			using var conn = Connect();
			conn.Open();
			using var cmd = conn.CreateCommand();
			cmd.CommandText = $@"
SELECT TOP 1
	UserAccountId
FROM
	USERACCOUNT
WHERE
	UserAccountName = N'{name}'";
			using var reader = cmd.ExecuteReader();
			if (reader == null)
			{
				return false;
			}
			return reader.Read();
		}

		public static bool IsExistingUserAccountEmail(string email)
		{
			using var conn = Connect();
			conn.Open();
			using var cmd = conn.CreateCommand();
			cmd.CommandText = $@"
SELECT TOP 1
	UserAccountId
FROM
	USERACCOUNT
WHERE
	UserAccountEmail = N'{email}'";
			using var reader = cmd.ExecuteReader();
			if (reader == null)
			{
				return false;
			}
			return reader.Read();
		}

		private static bool IsExistingTable(string tableName)
		{
			using var conn = Connect();
			conn.Open();
			using var cmd = conn.CreateCommand();
			cmd.CommandText = $@"
SELECT TOP 1
	COUNT(id)
FROM
	sysobjects
WHERE
	id = object_id('dbo.{tableName}')
	AND sysstat & 0xf = 3";
			using var reader = cmd.ExecuteReader();
			if (reader == null)
			{
				return false;
			}
			if (reader.Read())
			{
				int count = reader.GetInt32(0);
				if (count > 0)
				{
					return true;
				}
			}
			return false;
		}

		private static string? GetFirstPrimaryKeyColumnName(string tableName)
		{
			if (string.IsNullOrEmpty(tableName))
			{
				return null;
			}
			using var conn = Connect();
			conn.Open();
			using var cmd = conn.CreateCommand();
			cmd.CommandText = $@"
SELECT TOP 1
	ccu.COLUMN_NAME
FROM
    INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc, 
    INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu 
WHERE 
    ccu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME
    AND ccu.TABLE_NAME = tc.TABLE_NAME
    AND tc.CONSTRAINT_TYPE = 'PRIMARY KEY'
    AND ccu.TABLE_NAME = '{tableName}'";
			using var reader = cmd.ExecuteReader();
			if (reader == null)
			{
				return null;
			}
			if (reader.Read())
			{
				string columnName = reader.GetString(0);
				return columnName;
			}
			return null;
		}

		// TODO: This method is nothing but MAX(id_col) + 1, needa find some other way
		//
		private static int? GetNextId(string tableName)
		{
			if (!IsExistingTable(tableName))
			{
				return null;
			}
			string? primaryKeyColumnName = GetFirstPrimaryKeyColumnName(tableName);
			if (primaryKeyColumnName == null)
			{
				return null;
			}

			using var conn = Connect();
			conn.Open();
			using var cmd = conn.CreateCommand();
			cmd.CommandText = $@"
SELECT TOP 1
	MAX({primaryKeyColumnName}) + 1
FROM
	{tableName}";
			using var reader = cmd.ExecuteReader();
			if (reader == null)
			{
				return null;
			}
			if (reader.Read())
			{
				int value = reader.GetInt32(0);
				return value;
			}
			return null;
		}
	}
}
