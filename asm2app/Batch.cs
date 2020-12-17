using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2app
{
	class Batch
	{
		public string Name;
		public string Id;
		public int Age;
		public int TotalOrder;
		public int TotalMoney;
		public List<Custemurs> Custemurs;


		public Batch(string name)
		{
			Name = name;
			Custemurs = new List<Custemurs>();
		}

		public Custemurs FindCustemursById(string id)
		{
			return Custemurs.SingleOrDefault(s => s.Id.Equals(id));

		}

		public bool Add(Custemurs custemurs)
		{
			if (FindCustemursById(custemurs.Id) != null)
			{
				return false;
			}

			Custemurs.Add(custemurs);
			return true;
		}

		public bool DeleteCustemursById(string id)
		{
			var custemursInBatch = FindCustemursById(id);

			if (custemursInBatch == null) return false;

			Custemurs.Remove(custemursInBatch);
			return true;
		}

		public bool EditCustemursById(string id, string fullName, int age, int totalOrder, int totalMoney)
		{
			var custemursInBatch = FindCustemursById(id);

			if (custemursInBatch == null) return false;
			custemursInBatch.Id = id;
			custemursInBatch.FullName = fullName;
			custemursInBatch.Age = age;
			custemursInBatch.TotalOrder = totalOrder;
			custemursInBatch.TotalMoney = totalMoney;


			return true;
		}

		public void ShowAllCustemurs()
		{
			Console.WriteLine($"Batch: {Name}");
			Console.WriteLine("---------");
			foreach (var Custemurs in Custemurs)
            {
				Custemurs.ShowInfo();
            }
		}
	}
}
