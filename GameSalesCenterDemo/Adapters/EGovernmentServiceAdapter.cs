using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesCenterDemo.Abstract;
using GameSalesCenterDemo.EGovernmentServiceReference;
using GameSalesCenterDemo.Entities;

namespace GameSalesCenterDemo.Adapters
{
	class EGovernmentServiceAdapter:IUserCheckService
	{
		public bool CheckIfRealPerson(User user)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient();
			return client.TCKimlikNoDogrula(Convert.ToInt64(user.NationalityId), user.FirstName.ToUpper(),
				user.LastName.ToUpper(), user.DateOfBirth.Year);
		}
	}
}
