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
		public List<Custemurs> Custemurs;

		public Batch()
		{
			Name = "N/A";
		}

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

		public bool EditCustemursById(string id, string fullName, int age)
		{
			var custemursInBatch = FindCustemursById(id);

			if (custemursInBatch == null) return false;

			custemursInBatch.FullName = fullName;
			custemursInBatch.Age = age;

			return true;
		}
	}
}
