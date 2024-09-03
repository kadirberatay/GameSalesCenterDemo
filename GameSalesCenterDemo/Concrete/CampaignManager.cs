using GameSalesCenterDemo.Abstract;
using GameSalesCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Concrete
{
	public class CampaignManager : ICampaignService
	{
		public void AddCampaign(Campaign campaign)
		{
			Console.WriteLine("Campaign :"+campaign.CampaignName + " " + "is added.");
		}

		public void DeleteCampaign(Campaign campaign)
		{
			Console.WriteLine("Campaign : "+campaign.CampaignName + " " + "is deleted.");
		}

		public void UpdateCampaign(Campaign campaign)
		{
			Console.WriteLine("Campaign : " + campaign.CampaignName + " " + "is updated.");
		}
	}
}
