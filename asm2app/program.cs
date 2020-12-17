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
           
			Batch batch = new Batch("Trung");
           
            
            while (1 > 0)
			{
				UI.ShowMenuControl();
                int option = UI.EnterOption();

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("enter infomation custemurs");
                            batch.Add(new Custemurs(UI.EnterCustemursId(), UI.EnterCustemursFullName(), UI.EnterCustemursAge(), UI.EnterCustemursTotalOrder(), UI.EnterCustemursTotalMoney()));
                            
                            break;
                        }
                    case 2:
                        
                        string custemursId = UI.EnterCustemursId();
                        if (batch.FindCustemursById(custemursId) != null)
                         UI.ShowCustemursInfo(batch.FindCustemursById(custemursId)); 
                        else
                            Console.WriteLine("Custemurs not found");
                        break;
                    case 3:
                        UI.ShowMenuEdit();
                        var tinhnang = UI.Enter();
                        switch (tinhnang)
                        {
                            case 1:
                                batch.Add(new Custemurs(UI.EnterCustemursId(), UI.EnterCustemursFullName(), UI.EnterCustemursAge(), UI.EnterCustemursTotalOrder(), UI.EnterCustemursTotalMoney()));
                                Console.WriteLine("========");

                                break;
                            case 2:
                                custemursId = UI.EnterCustemursId();
                                if (batch.FindCustemursById(custemursId) != null)
                                {
                                    batch.EditCustemursById(custemursId,
                                                               UI.EnterCustemursFullName(),
                                                               UI.EnterCustemursAge(),
                                                               UI.EnterCustemursTotalOrder(),
                                                               UI.EnterCustemursTotalMoney());
                                }
                                break;
                            case 3:
                                custemursId = UI.EnterCustemursId();
                                batch.DeleteCustemursById(custemursId);
                                break;

                        }
                        break;
                    case 4:
                        batch.ShowAllCustemurs();
                        break;

                }

                Console.ReadLine();
            }
        }
    }
}

