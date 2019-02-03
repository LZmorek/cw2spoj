using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program krokTrzeci = new Program();
            krokTrzeci.iloscProb();
            Console.WriteLine("dziekuje za korzystanie z generatora silniowynikow 231254 ver 3.0");
            Console.ReadKey();

        }
        public int TakeNumber(int number)
        {
            string end = "";
            
            do
            {
                try
                {
                    Console.WriteLine("prosze wpisac liczbe calkowita powyzej zera: ");
                    string numberSTR = Console.ReadLine();
                    number = Convert.ToInt32(numberSTR); 
                    Console.WriteLine("aktualny status liczby: "+number+"");
                    if (number > 0&&number<1000000000)
                    {
                        Console.WriteLine("dziekujemy za prawidlowa liczbe");
                        end = "end";
                    }
                    else
                    {
                        Console.WriteLine("wybrano liczbe ktora nie spelnia warunko. prosze wybierz liczbe nieujemna wieksza od 0.");
                    }
                    
                }
                catch (FormatException )
                {
                    Console.WriteLine("zly format liczby");
                }
                
            } while (end != "end");
            return number;
        }
        public void LiczSilnia(int number)
        {
            Console.WriteLine("aktualny status liczby: "+number+"");
            
            
            int silnia = 1;
            for (int i = 1; i <= number; i++)
            {
                silnia *= i;
                Console.WriteLine("silnia: " + silnia + "");  
            }
            Console.WriteLine(" Liczba Dziesietna: " + (silnia / 10) + " Liczba Jednosci: " + (silnia % 10) + "");
            Console.ReadKey();
        }
        public void iloscProb()
        {
            string end = "";
            do
            {
                Console.WriteLine("podaj ilosc prob: ");
                string proby = Console.ReadLine();
                int liczbaProb = Convert.ToInt32(proby);
                if (liczbaProb >= 1 && liczbaProb <= 30)
                {
                    for (int i = 1; i <= liczbaProb; i++)
                    {
                        int number = 0;
                        Program krokjeden = new Program();
                        Program krokdwa = new Program();
                        number = krokjeden.TakeNumber(number);
                        krokdwa.LiczSilnia(number);
                    }
                    end = "end";
                }
                else
                {
                    Console.WriteLine("podano bledna liczbe. podaj liczbe prob z przedzialu 1-30");
                }
            } while (end != "end");
        }
    }
}
