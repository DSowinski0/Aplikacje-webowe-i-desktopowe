using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Wybor
    {
        public int[] numbers = new int[10];
        public int indexOfMax;

        public void sortOsc()
        {
            



            for (int i = 0; i < numbers.Length; i++)
            {

                //int max = findMax(i);
                
               // numbers[indexOfMax] = numbers[i];
               // numbers[i] = max;

                findMax(i);
                (numbers[i], numbers[indexOfMax]) = (numbers[indexOfMax], numbers[i]);


            }
        
        
        
        
        
        
        
        
        }
        // public int x { get; set; }



        public int findMax(int startIndex) 
        {
            int max = numbers[startIndex];
            indexOfMax = startIndex;
            
            for (int i = startIndex+1; i < numbers.Length; i++) 
            {
                if (numbers[i] > max) 
                {

                    max = numbers[i];
                    indexOfMax = i;
                
                }
            
            
            }

            return max;
                
        }



        public void GetNumbers()
        {

            Console.WriteLine("Podaj 10 liczb: ");

            for ( int i = 0; i < numbers.Length; i++ ) 
            {
                Console.WriteLine("Podaj liczbę: "+ (i + 1));
                Int32.TryParse(Console.ReadLine(), out numbers[i]);
            }

        }

        public  void ShowNumbers()
        {

            Console.WriteLine("Podałeś następujące liczby... ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
                
            }Console.WriteLine();

        }

    }
}
