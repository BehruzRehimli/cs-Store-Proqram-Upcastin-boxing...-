using Homework_task.Exceptions;
using System;

namespace Homework_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store Bravo=new Store() {AlcoholPercentLimit=30,DairyProductCountLimit=2 };
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine(">>>>>>>>>>>>>>>>>MENU<<<<<<<<<<<<<<<<<<\n");
                Console.WriteLine("      1. Drink product elave et.");
                Console.WriteLine("      2. Dairy product elave et.");
                Console.WriteLine("      3. Butun productlara bax.");
                Console.WriteLine("      4. Verilmish nomreli producta bax.");
                Console.WriteLine("      5. Drink productlara bax.");
                Console.WriteLine("      6. Dairy productlara bax.");
                Console.WriteLine("      7. Ada gore axtarish et.");
                Console.WriteLine("      8. Qiymet araligina gore axtarish et.");
                Console.WriteLine("      9. Siyahidan mehsulu sil.");
                Console.WriteLine("      0. Menyudan chix.\n");
                Console.WriteLine("\nSechiminizi daxil edin ve 'ENTER' duymesini kilikleyin.");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        try
                        {
                            Bravo.AddProduct(Case1());
                            Console.WriteLine("\nMehsul elave olundu...");
                        }
                        catch (PercentLimitException ex)
                        {
                            Console.WriteLine("\nMehsul elave oluna bilmedi.");
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        try
                        {
                            Bravo.AddProduct(Case2());
                            Console.WriteLine("\nMehsul elave olundu...");
                        }
                        catch (DairyProductLimitBroken ex)
                        {
                            Console.WriteLine("\nMehsul elave oluna bilmedi.");
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();

                        break;
                    case "3":
                        Console.Clear();
                        foreach (var item in Bravo.Products)
                        {
                            item.ShowInfo();
                        }
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        try
                        {
                            Bravo.GetProductByNo(Case4()).ShowInfo();
                        }
                        catch (ThereIsNotProductNo ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        foreach (var item in Bravo.GetDrinkProducts())
                        {
                            item.ShowInfo();
                        }
                        if (Bravo.GetDrinkProducts().Length==0)
                        {
                            Console.WriteLine("\nHal hazirda magazada icki mehsulu yoxdur.\n");
                        }
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Clear();
                        foreach (var item in Bravo.GetDairyProducts())
                        {
                            item.ShowInfo();
                        }
                        if (Bravo.GetDairyProducts().Length == 0)
                        {
                            Console.WriteLine("\nHal hazirda magazada sud mehsulu yoxdur.\n");
                        }
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Axtardiginiz mehsulun adini daxil edin.\n");
                        string input7=Console.ReadLine();
                        int counter = 0;
                        foreach (var item in Bravo.Products)
                        {
                            if (item.Name.Contains(input7))
                            {
                                item.ShowInfo();
                            }
                            else
                            {
                                counter++;
                            }
                        }
                        if (counter==Bravo.Products.Length)
                        {
                            Console.WriteLine("\nAxtardigizin mehsul magazamizda movcud deyil.\n");
                        }
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Axtardiginiz qiymet araliginin minimum ve maksimum deyerlerini daxil edin.\n");
                        int inputmin = 0;
                        int inputmax = 0;
                        int count = 0;
                        try
                        {
                            Console.WriteLine("\nMinimum qiymeti daxil edin.\n");
                            inputmin=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nMaksimum qiymeti daxil edin.\n");
                            inputmax = Convert.ToInt32(Console.ReadLine());
                            foreach (var item in Bravo.Products)
                            {
                                if (item.Price>=inputmin&&item.Price<=inputmax)
                                {
                                    item.ShowInfo();
                                }
                                else
                                {
                                    count++;
                                }
                            }
                            if (count==Bravo.Products.Length)
                            {
                                Console.WriteLine("\nMagazamizda bu qiymet araliginda mehsul yoxdur.\n");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nQiymeti yanlish daxil etdiniz...\n");
                        }
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();

                        break;
                    case "9":
                        Console.Clear();
                        int delete = Case9();
                        try
                        {
                            Bravo.RemoveProduct(delete);
                            Console.WriteLine("\nMehsul silindi...");
                        }
                        catch (ThereIsNotProductNo ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Proqrami baglamaq istediyinizden eminsiz?\n1.Yes\n2.No\n");
                        Console.WriteLine("\nSechiminizi daxil edin ve 'ENTER' duymesini kilikleyin.");
                        string exit=Console.ReadLine();
                        if (exit=="2")
                        {
                            input = "1";
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nZehmet olmasa sechiminiz duzgun daxil edin. Siz 0-dan 10-a qeder reqem daxil ede bilersiz.");
                        Console.WriteLine("\nMenuya qayitmaq uchun 'ENTER' duymesini kilikleyin.");
                        Console.ReadLine();
                        break;
                }

            } while (input!="0");



        }
        static Drink Case1()
        {
            Drink dr = new Drink();

            Console.WriteLine("Mehsulun adini qeyd edin: \n");
            dr.Name = Console.ReadLine();
            Console.WriteLine("\nMehsulun qiymetini daxil edin: \n");
            bool excep1;
            do
            {
                excep1 = false;
                try
                {
                    dr.Price = Convert.ToInt32(Console.ReadLine());
                }
                catch (PriceCantBeMinus ex)
                {
                    Console.WriteLine(ex.Message);
                    excep1 = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nQiymet yanlish qeyd olundu!!!\nZehmet olmasa duzgun qeyd edin.");
                    excep1 = true;
                }
            } while (excep1 == true);
            Console.WriteLine("\nIckinin alkaqol faizini daxil edin.\n");
            do
            {
                excep1 = false;
                try
                {
                    dr.AlcoholPercent = Convert.ToByte(Console.ReadLine());
                }
                catch (PercentException ex)
                {
                    Console.WriteLine(ex.Message);
                    excep1 = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nFaiz yanlish qeyd olundu!!!\nZehmet olmasa duzgun qeyd edin.");
                    excep1 = true;
                }
            } while (excep1 == true);
            return dr;
        }
        static Dairy Case2()
        {
            Dairy dr = new Dairy();
            Console.WriteLine("Mehsulun adini qeyd edin: \n");
            dr.Name = Console.ReadLine();
            Console.WriteLine("\nMehsulun qiymetini daxil edin: \n");
            bool excep1;
            do
            {
                excep1 = false;
                try
                {
                    dr.Price = Convert.ToInt32(Console.ReadLine());
                }
                catch (PriceCantBeMinus ex)
                {
                    Console.WriteLine(ex.Message);
                    excep1 = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nQiymet yanlish qeyd olundu!!!\nZehmet olmasa duzgun qeyd edin.");
                    excep1 = true;
                }
            } while (excep1 == true);
            Console.WriteLine("\nMehsulun yagliliq faizini qeyd edin.\n");
            do
            {
                excep1 = false;
                try
                {
                    dr.FatPercent= Convert.ToByte(Console.ReadLine());
                }
                catch (PercentException ex)
                {
                    Console.WriteLine(ex.Message);
                    excep1 = true;
                }
                catch (Exception )
                {
                    Console.WriteLine("\nYagliliq faizi yanlish qeyd olundu!!!\nZehmet olmasa duzgun qeyd edin.");
                    excep1 = true;
                }

            } while (excep1==true);
            return dr;

        }
        static int Case4()
        {
            Console.WriteLine("\nAxtardiginiz mehsulun nomresini qeyd edin zehmet olmasa.\n");
            int No4=0;
            bool excep4;
            do
            {
                excep4 = false;
                try
                {
                    No4 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nNomre yanlish qeyd olundu!!!\nZehmet olmasa duzgun qeyd edin.");
                    excep4 = true;
                }
            } while (excep4 == true);
            return No4;
        }
        static int Case9()
        {
            Console.WriteLine("\nZehmet olmasa silmek istediyiniz mehsulun nomresini qeyd edin.\n");
            bool excep9;
            int delete =0;
            do
            {
                excep9 = false;
                try
                {
                    delete = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nNomre yanlish qeyd olundu!!!\nZehmet olmasa duzgun qeyd edin.");
                    excep9 = true;
                }
            } while (excep9 == true);
            return delete;

        }
    }
}
