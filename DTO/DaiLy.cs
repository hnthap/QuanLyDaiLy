using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DaiLy
	{
		public string MaDaiLy { get; set; } = string.Empty;
		public string TenDaiLy { get; set; } = string.Empty;
		public string MaLoaiDaiLy { get; set; } = string.Empty;
		public string DienThoai { get; set; } = string.Empty;
		public string DiaChi { get; set; } = string.Empty;
		public string MaQuan { get; set; } = string.Empty;
		public DateTime NgayTiepNhap { get; set; }
		public string Email { get; set; } = string.Empty;
		public SqlMoney TienNo { get; set; }

		public DaiLy()
		{
			// Nothing
		}

		public DaiLy(string maDaiLy, string tenDaiLy, string maLoaiDaiLy, string dienThoai, string diaChi, string maQuan, DateTime ngayTiepNhap, string email, SqlMoney tienNo)
		{
			MaDaiLy = maDaiLy;
			TenDaiLy = tenDaiLy;
			MaLoaiDaiLy = maLoaiDaiLy;
			DienThoai = dienThoai;
			DiaChi = diaChi;
			MaQuan = maQuan;
			NgayTiepNhap = ngayTiepNhap;
			Email = email;
			TienNo = tienNo;
		}
	}
}
