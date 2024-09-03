using GameSalesCenterDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Entities
{
	public class User:IEntity
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string NationalityId { get; set; }
		public decimal Balance { get; set; }
	}
}
