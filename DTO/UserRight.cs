using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class UserRight
	{
		public int UserRightId { get; set; }
		public string UserRightName { get; set; } = "";

		public UserRight()
		{
			// Nothing
		}

		public UserRight(int userRightId, string userRightName)
		{
			UserRightId = userRightId;
			UserRightName = userRightName;
		}
	}
}
