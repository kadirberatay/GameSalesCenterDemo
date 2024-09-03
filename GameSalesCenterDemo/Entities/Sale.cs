using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Entities
{
	public class Sale
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int UserId { get; set; }
		public virtual User User { get; set; } // buradaki virtual sayesinde program.cs'te satıştaki kullanıcının bilgilerine eriştik? EntityFramework sağladı, (ORM), newleyerek sale.User'dan User bilgileri geldi.

		public int? CampaignId { get; set; } // Kampanya isteğe bağlı olabilir
		public virtual Campaign Campaign { get; set; }

		public int GameId { get; set; }
		public virtual Game Game { get; set; }
	}
}
