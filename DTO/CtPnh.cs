using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class CtPnh
	{
		public string MaPhieuNhap { get; set; } = string.Empty;
		public string MaMH { get; set; } = string.Empty;
		public int SoLuongNhap { get; set; }
		public SqlMoney DonGiaNhap { get; set; }
		public SqlMoney ThanhTien { get; set; }

		public CtPnh()
		{
			// Nothing
		}

		public CtPnh(string maPhieuNhap, string maMH, int soLuongNhap, SqlMoney donGiaNhap, SqlMoney thanhTien)
		{
			MaPhieuNhap = maPhieuNhap;
			MaMH = maMH;
			SoLuongNhap = soLuongNhap;
			DonGiaNhap = donGiaNhap;
			ThanhTien = thanhTien;
		}
	}
}
