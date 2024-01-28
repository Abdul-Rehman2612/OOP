using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeproblem
{
    internal class Program
    {
        static void Main()
        {
            int numOfElements;
            Console.Write("Enter the number of elments you want to enter: ");
            numOfElements=int.Parse(Console.ReadLine());
            int[] Elements = new int[numOfElements];
            int i = 0;
            while(i<numOfElements)
            {
                Elements[i]=int.Parse(Console.ReadLine());
                i++;
            }
            int mostOccEle=-1;
            int maxCount = 0;
            for(int j=0;j<Elements.Length; j++)
            {
                int count = 0;
                if (Elements[j]!=-1)
                {
                int temp = Elements[j];
                for(int k=0;k<Elements.Length;k++)
                {
                    if (Elements[k]==temp)
                    {
                        Elements[k]=-1;
                        count++;
                    }
                }
                if(count>maxCount)
                {
                    maxCount= count;
                    mostOccEle = temp;
                }

                }
            }
            Console.WriteLine("Most occured element is: {0} and its number is {1}.",mostOccEle,maxCount);
            Console.ReadKey();
        }

    }
}
