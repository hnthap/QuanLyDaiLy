using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class CtBccn
	{
		public string MaBCCN { get; set; } = string.Empty;
		public string MaDaiLy { get; set; } = string.Empty;
		public SqlMoney NoDau { get; set; } = SqlMoney.Zero;
		public SqlMoney PhatSinh { get; set; } = SqlMoney.Zero;
		public SqlMoney NoCuoi { get; set; } = SqlMoney.Zero;

		public CtBccn()
		{
			// Nothing
		}

		public CtBccn(string maBCCN, string maDaiLy, SqlMoney noDau, SqlMoney phatSinh, SqlMoney noCuoi)
		{
			MaBCCN = maBCCN;
			MaDaiLy = maDaiLy;
			NoDau = noDau;
			PhatSinh = phatSinh;
			NoCuoi = noCuoi;
		}
	}
}
