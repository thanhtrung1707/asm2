using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2app
{
	class UI
	{



		public static void ShowBatchInfo(Batch batch)

		{
			List<Custemurs> ListCustemurs = new List<Custemurs>();
			//int NumberCustemurs;

			//Console.WriteLine("Enter number custemurs");


			//NumberCustemurs = int.Parse(Console.ReadLine());
			//for (int i = 0; i < NumberCustemurs; i++)
			//{
			//	Console.WriteLine("Enter information custemurs the  {0}", (i + 1));
			//	string Id = UI.EnterCustemursId();
			//	string fullName = UI.EnterCustemursFullName();
			//	int age = UI.EnterCustemursAge();
			//	int totalOrder = UI.EnterCustemursTotalOrder();
			//	int totalMoney = UI.EnterCustemursTotalMoney();
			//	Console.WriteLine($"Batch name: {batch.Name}");
			//	Console.WriteLine($"Number custemurs in batch: {batch.Custemurs.Count} custemurs");
			//}

		}


		public static string EnterCustemursId()
		{
			Console.WriteLine("Please enter custemurs Id: ");
			return Console.ReadLine();
		}
		public static string EnterCustemursFullName()
		{
			Console.WriteLine("Please enter custemurs Full Name: ");
			return Console.ReadLine();
		}
		public static int EnterCustemursAge()
		{
			Console.WriteLine("Please enter custemurs Age: ");
			return int.Parse(Console.ReadLine());
		}
		public static int EnterCustemursTotalOrder()
		{
			Console.WriteLine("Please enter custemurs total order");

			return int.Parse(Console.ReadLine());
		}
		public static int EnterCustemursTotalMoney()
		{
			Console.WriteLine("Please enter custermurs total Money");
			return int.Parse(Console.ReadLine());
		}
		public static void ShowMenuControl()
		{
			Console.WriteLine("Please choose your command control below");
			Console.WriteLine("1. Add Custemurs");
			Console.WriteLine("2. Find Custemurs by Id");
			Console.WriteLine("3. Edit Custemurs ");
			Console.WriteLine("4. Exit");
		}


		public static int EnterOption()
		{
			Console.Write("Enter your option:");
			return int.Parse(Console.ReadLine());
		}
		public static void ShowMenuEdit()
		{
			Console.WriteLine("Please choose");
			Console.WriteLine("1. Add");
			Console.WriteLine("2. edit");
			Console.WriteLine("3. Delete");
		}

		public static void ShowCustemursInfo(Custemurs custemurs)
		{
			custemurs.ShowInfo();
			Console.WriteLine("---------");
		}

		public static int Enter()
		{
			Console.WriteLine("Enter tinh nang");
			return int.Parse(Console.ReadLine());
		}


	}
}

