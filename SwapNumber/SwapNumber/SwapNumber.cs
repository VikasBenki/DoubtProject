using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    public class SwapNumber
    {
        public void SwapingNumbers()
        {
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("enter the first NUM");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second Num");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swaping {firstNm} {secondNum}");
            temp=firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("after swaping {firstNum} {secondNum}");
       }
    }
}
