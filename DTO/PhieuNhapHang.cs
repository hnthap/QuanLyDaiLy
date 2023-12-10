using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhieuNhapHang
	{
		public string MaPhieuNhap { get; set; } = string.Empty;
		public DateTime NgayNhap { get; set; }
		public SqlMoney TongTien { get; set; }

		public PhieuNhapHang()
		{
			// Nothing
		}

		public PhieuNhapHang(string maPhieuNhap, DateTime ngayNhap, SqlMoney tongTien)
		{
			MaPhieuNhap = maPhieuNhap;
			NgayNhap = ngayNhap;
			TongTien = tongTien;
		}
	}
}
