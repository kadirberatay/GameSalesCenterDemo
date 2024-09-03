using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Entities
{
	public class Game
	{
		public int Id { get; set; }
		public string GameName { get; set; }
		public decimal GamePrice { get; set; }
		public DateTime ReleaseDate { get; set; }
	}
}
