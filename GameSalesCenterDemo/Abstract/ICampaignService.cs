﻿using GameSalesCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Abstract
{
	public interface ICampaignService
	{
		void AddCampaign(Campaign campaign);
		void DeleteCampaign(Campaign campaign);
		void UpdateCampaign(Campaign campaign);
	}
}
