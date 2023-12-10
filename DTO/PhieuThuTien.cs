using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhieuThuTien
	{
		public string MaPhieuThuTien { get; set; } = string.Empty;
		public string MaDaiLy { get; set; } = string.Empty;
		public DateTime NgayThuTien { get; set; } = DateTime.Now;
		public SqlMoney SoTienThu { get; set; } = SqlMoney.Zero;

		public PhieuThuTien()
		{
			// Nothing
		}

		public PhieuThuTien(string maPhieuThuTien, string maDaiLy, DateTime ngayThuTien, SqlMoney soTienThu)
		{
			MaPhieuThuTien = maPhieuThuTien;
			MaDaiLy = maDaiLy;
			NgayThuTien = ngayThuTien;
			SoTienThu = soTienThu;
		}
	}
}
