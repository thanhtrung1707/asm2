using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2app
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Custemurs> ListCustemurs = new List<Custemurs>();
			int NumberCustemurs;
			Console.WriteLine("Enter number custemurs");

			NumberCustemurs = int.Parse(Console.ReadLine());
			for (int i = 0; i < NumberCustemurs; i++)
			{
				Console.WriteLine("Enter information custemurs the  {0}", (i + 1));

				Custemurs custemurs = new Custemurs();
				Batch batch = new Batch("List Custemurs");
				string custemursId = UI.EnterCustemursId();

				string fullName = UI.EnterCustemursFullName();

				int age = UI.EnterCustemursAge();
				int totalOrder = UI.EnterCustemursTotalOrder();
     //           {
					//int order1, total = 0;
					//int[] sum;
					//int order1 = int.Parse(Console.ReadLine());
					//sum = new int[order1];
					//for (int a = 0; a < order1; a++)
					//{
					//	Console.WriteLine("enter order{0}: ", a + 1);
					//	sum[a] = int.Parse(Console.ReadLine());
     //               }

					//{
					//	total += order1(a);
     //               }
                
				int totalMoney = UI.EnterCustemursTotalMoney();
			}
				{
					UI.ShowMenuControl();
					var option = UI.EnterOption();

					switch (option)
					{
						case 1:
						//Console.WriteLine($"Id: {Id}");
						//Console.WriteLine($"Full Name: {FullName}");
						//Console.WriteLine($"Age: {Age}");

						break;
						case 2:
							//custemursId = UI.EnterCustemursId();
							//if (batch.FindCustemursById(custemursId) != null)
							//	UI.ShowCustemursInfo(batch.FindCustemursById(custemursId));
							//else
							//	Console.WriteLine("Custemurs not found");
							break;
					case 3:
						UI.ShowMenuEdit();
						var tinhnang = UI.Enter();
                        switch (tinhnang)
							{
							case 1:
						break;
							case 2:
								break;
							case 3:
								break;

                        }
							break;
						case 4:
							// Todo
							break;
						case 5:
							break;
					}

					Console.ReadLine();
				}
			}
		}
	}

