using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class MainClass
    {

        public static void Main()
        {
            while (true)
            {
                int[] arr = { 12,2,6,7,11 };
                Console.WriteLine(SeatingStudents(arr));
                Console.ReadLine();
            }
        }

        public static int SeatingStudents(int[] arr)
        {
            int[] fullrow=new int[arr.Length-1];
            int k = 0;
            int sayac = 0;
            for (int i = 1; i < arr.Length; i++)
            {            
                fullrow[k] = arr[i];
                k++;
            }

            for (int i = 1; i < arr[0]-1; i++)
            {
                if (!fullrow.Contains(i))
                {
                    if (i%2==0)
                    {
                        if (!fullrow.Contains(i+2))
                        {
                            sayac++;
                        }
                    }
                    else if (i%2==1)
                    {
                        if (!fullrow.Contains(i+1) && !fullrow.Contains(i+2))
                        {
                            sayac+=2;
                        }
                        else if (fullrow.Contains(i + 1) && !fullrow.Contains(i + 2))
                        {
                            sayac++;
                        }
                        else if (!fullrow.Contains(i + 1) && fullrow.Contains(i + 2))
                        {
                            sayac++;
                        }
                    }
                }              
            }
            if (!fullrow.Contains(arr[0]-1))
            {
                sayac++;
            }
            return sayac;

        }
   }
}
