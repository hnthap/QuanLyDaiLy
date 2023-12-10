using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class CtBcds
	{
		public string MaBCDS { get; set; } = string.Empty;
		public string MaDaiLy { get; set; } = string.Empty;
		public int SoPhieuXuat { get; set; }
		public SqlMoney TongTriGia { get; set; } = SqlMoney.Zero;
		public float TyLe;

		public CtBcds()
		{
			// Nothing
		}

		public CtBcds(string maBCDS, string maDaiLy, int soPhieuXuat, SqlMoney tongTriGia, float tyLe)
		{
			MaBCDS = maBCDS;
			MaDaiLy = maDaiLy;
			SoPhieuXuat = soPhieuXuat;
			TongTriGia = tongTriGia;
			TyLe = tyLe;
		}
	}
}
