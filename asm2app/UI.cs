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
			Console.WriteLine($"Batch name: {batch.Name}");
			Console.WriteLine($"Number students in batch: {batch.Custemurs.Count} student");
			Console.WriteLine("========");
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
			Console.WriteLine("1. View infomation Custemurs");
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
		public static int Enter()
        {
			Console.WriteLine("Enter tinh nang");
			return int.Parse(Console.ReadLine());
        }
		
	
	}
}
