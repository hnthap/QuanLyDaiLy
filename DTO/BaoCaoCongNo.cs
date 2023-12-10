using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class BaoCaoCongNo
	{
		public string MaBCCN { get; set; } = string.Empty;
		public int Thang { get; set; }
		public int Nam { get; set; }
		public SqlMoney TongNo { get; set; } = SqlMoney.Zero;

		public BaoCaoCongNo()
		{
			// Nothing
		}

		public BaoCaoCongNo(string maBCCN, int thang, int nam, SqlMoney tongNo)
		{
			MaBCCN = maBCCN;
			Thang = thang;
			Nam = nam;
			TongNo = tongNo;
		}
	}
}
