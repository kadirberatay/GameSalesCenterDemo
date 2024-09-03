using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Entities
{
	public class Campaign
	{
		public int Id { get; set; }
		public string CampaignName { get; set; }
		public decimal Discount { get; set; } = 0.50m;
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		//public virtual ICollection<Game> Games { get; set; } = new List<Game>(); //bir kampanya birden fazla oyunda dahil olabilir.

	}
}
