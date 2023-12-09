using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhieuXuatHang
	{
		public string MaPhieuXuat { get; set; } = string.Empty;
		public string MaDaiLy { get; set; } = string.Empty;
		public DateTime NgayXuat { get; set; }
		public SqlMoney TongTien { get; set; }
		public SqlMoney SoTienTra { get; set; }
		public SqlMoney ConLai { get; set; }

		public PhieuXuatHang()
		{
			// Nothing
		}

		public PhieuXuatHang(string maPhieuXuat, string maDaiLy, DateTime ngayXuat, SqlMoney tongTien, SqlMoney soTienTra, SqlMoney conLai)
		{
			MaPhieuXuat = maPhieuXuat;
			MaDaiLy = maDaiLy;
			NgayXuat = ngayXuat;
			TongTien = tongTien;
			SoTienTra = soTienTra;
			ConLai = conLai;
		}
	}
}
