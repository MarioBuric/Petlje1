using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricmariovjezbapetlje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;
            float prosjek;
            int zbrojOcjena = 0;
            float brojOcjena = 0;
            

            do
            {


                Console.WriteLine("upisite ocjenu:");
                ocjena = Convert.ToInt16(Console.ReadLine());
                brojOcjena++;
                if (ocjena == 1)
                {
                    prosjek = 1;
                    break;
                }
                 
                else if (ocjena > 5 || ocjena < 0)

                {
                    Console.WriteLine("Pogresan unos,unesite ponovno.");
                }
                else if (ocjena != 0)
                {
                    brojOcjena++;
                    zbrojOcjena += ocjena;
                    
                }
                prosjek = zbrojOcjena / brojOcjena;
            }

            while (ocjena != 0);
            Console.WriteLine("Prosjek ocijena je " + prosjek);
            Console.ReadKey();


            }
        

    }
    }

