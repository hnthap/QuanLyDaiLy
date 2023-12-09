using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Dvt
	{
		public string MaDVT { get; set; } = string.Empty;
		public string TenDVT { get; set; } = string.Empty;

		public Dvt()
		{
			// Nothing
		}

		public Dvt(string maDVT, string tenDVT)
		{
			MaDVT = maDVT;
			TenDVT = tenDVT;
		}
	}
}
