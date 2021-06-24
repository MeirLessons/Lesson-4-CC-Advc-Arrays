using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_CC_Arrays_Advc
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Dimension Array:

            int[,] myDemArr =  //new int[8,10]
            {
                {1,2,3,4,5,6,7,8,9,10 },
                {2,4,6,8,10,12,14,16,18,20 },
                {3,6,9,12,15,18,21,24,27,30 },
                {4,8,12,16,20,24,28,32,36,40 },
                {5,10,3,4,5,6,7,8,9,50 },
                {6,12,3,4,5,6,7,8,9,60 },
                {7,14,3,4,5,6,7,8,9,70 },
                {8,16,24,32,40,48,56,64,72,80 },
            };
            for (int i = 0; i < myDemArr.GetLength(0); i++)
            {
                for (int j = 0; j < myDemArr.GetLength(1); j++)
                {
                    Console.WriteLine();
                }
            }

            #endregion

            #region jagged array

            string[][] myJadArr = new string[2][];
            myJadArr[0] = new string[3] {"Avi","Moshe","Dani" };
            myJadArr[1] = new string[4] { "Gadi", "4", "Yossi", "Ran" };

            #endregion

            #region Sort Arrays

            //int From 0
            int[] arrForSort = { 13, 5, 2, 8, 1 };
            Array.Sort(arrForSort);
            for (int i = 0; i < arrForSort.Length; i++)
            {
                Console.WriteLine(arrForSort[i]);
            }

            //string  A-Z
            string[] myStrForSort = { "Soso", "David", "Avi" };
            Array.Sort(myStrForSort);

            #endregion

            #region Rank Property

            char[,,,] charsDim = new char[5, 2 ,3 ,4];
            Console.WriteLine(charsDim.Rank);//Print 4

            #endregion

            #region IndexOf Method

            double[] dblArr = { 3.2, 4.5, 7.2, 8 };

            int index = Array.IndexOf(dblArr, 7.2);

            double num = double.Parse(Console.ReadLine());
            int index2 = Array.IndexOf(dblArr, num);
            if(index2 == -1)
            {
                Console.WriteLine("Try Another Number");
            }
            else
            {
                Console.WriteLine(index2);
            }

            #endregion
        }
    }
}
