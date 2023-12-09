using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class CtPxh
	{
		public string MaPhieuXuat { get; set; } = string.Empty;
		public string MaMH { get; set; } = string.Empty;
		public int SoLuongXuat { get; set; }
		public SqlMoney ThanhTien { get; set; } = SqlMoney.Zero;
		public SqlMoney DonGiaXuat { get; set; } = SqlMoney.Zero;

		public CtPxh()
		{
			// Nothing
		}

		public CtPxh(string maPhieuXuat, string maMH, int soLuongXuat, SqlMoney thanhTien, SqlMoney donGiaXuat)
		{
			MaPhieuXuat = maPhieuXuat;
			MaMH = maMH;
			SoLuongXuat = soLuongXuat;
			ThanhTien = thanhTien;
			DonGiaXuat = donGiaXuat;
		}
	}
}
