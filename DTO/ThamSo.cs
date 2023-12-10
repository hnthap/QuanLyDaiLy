using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ThamSo
	{
		public int SoDaiLyToiDa { get; set; }
		public float TiLeDonGia { get; set; }

		public ThamSo()
		{
			// Nothing
		}

		public ThamSo(int soDaiLyToiDa, float tiLeDonGia)
		{
			SoDaiLyToiDa = soDaiLyToiDa;
			TiLeDonGia = tiLeDonGia;
		}
	}
}
