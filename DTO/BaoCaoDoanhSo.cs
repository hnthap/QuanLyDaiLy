using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class BaoCaoDoanhSo
	{
		public string MaBCDS { get; set; } = string.Empty;
		public int Thang { get; set; }
		public int Name { get; set; }
		public SqlMoney TongDoanhThu { get; set; } = SqlMoney.Zero;

		public BaoCaoDoanhSo()
		{
			// Nothing
		}

		public BaoCaoDoanhSo(string maBCDS, int thang, int name, SqlMoney tongDoanhThu)
		{
			MaBCDS = maBCDS;
			Thang = thang;
			Name = name;
			TongDoanhThu = tongDoanhThu;
		}
	}
}
