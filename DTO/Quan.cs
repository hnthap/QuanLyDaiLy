using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Quan
	{
		public string MaQuan { get; set; } = string.Empty;
		public string TenQuan { get; set; } = string.Empty;

		public Quan()
		{
			// Nothing
		}

		public Quan(string maQuan, string tenQuan)
		{
			MaQuan = maQuan;
			TenQuan = tenQuan;
		}
	}
}
