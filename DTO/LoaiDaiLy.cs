using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class LoaiDaiLy
	{
		public string MaLoaiDaiLy { get; set; } = string.Empty;
		public string TenLoaiDaiLy { get; set; } = string.Empty;
		public SqlMoney SoNoToiDa { get; set; }

		public LoaiDaiLy()
		{
			// Nothing
		}

		public LoaiDaiLy(string maLoaiDaiLy, string tenLoaiDaiLy, SqlMoney soNoToiDa)
		{
			MaLoaiDaiLy = maLoaiDaiLy;
			TenLoaiDaiLy = tenLoaiDaiLy;
			SoNoToiDa = soNoToiDa;
		}
	}
}
