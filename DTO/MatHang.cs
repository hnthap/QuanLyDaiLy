using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class MatHang
	{
		public string MaMH { get; set; } = string.Empty;
		public string TenMH { get; set; } = string.Empty;
		public string MaDVT { get; set; } = string.Empty;
		public int SoLuongTon { get; set; }
		public SqlMoney DonGiaNhap { get; set; }
		public SqlMoney DonGiaXuat { get; set; }

		public MatHang()
		{
			// Nothing
		}

		public MatHang(string maMH, string tenMH, string maDVT, int soLuongTon, SqlMoney donGiaNhap, SqlMoney donGiaXuat)
		{
			MaMH = maMH;
			TenMH = tenMH;
			MaDVT = maDVT;
			SoLuongTon = soLuongTon;
			DonGiaNhap = donGiaNhap;
			DonGiaXuat = donGiaXuat;
		}
	}
}
