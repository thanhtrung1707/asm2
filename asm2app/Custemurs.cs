using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2app
{
    class Custemurs
    {
		public string Id;
		public string FullName;
		public int Age;
		public int TotalOrder;
		public int TotalMoney;

		
		 
		public Custemurs(string id, string fullName, int age, int totalOrder, int totalMoney)
		{
			Id = id;
			FullName = fullName;
			Age = age;
			TotalOrder = totalOrder;
			TotalMoney = totalMoney;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Id: {Id}");
			Console.WriteLine($"Full Name: {FullName}");
			Console.WriteLine($"Age: {Age}");
			Console.WriteLine($" TotalOrder: {TotalOrder}");
			Console.WriteLine($"TotalMoney: {TotalMoney}");
		}
	}
}

           

    

