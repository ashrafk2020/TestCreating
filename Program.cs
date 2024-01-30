
using System;

namespace _11new
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesList = new List<string>();
           dynamic myDynamicVariable = 5;
           System.Console.WriteLine(myDynamicVariable);
           myDynamicVariable = "ashraf";
           System.Console.WriteLine(myDynamicVariable);
           myDynamicVariable = new List<float>();
           myDynamicVariable.Add(10f);
           myDynamicVariable.Add(5.2f);
           myDynamicVariable.Add(3.4f);
    
           foreach (var item in myDynamicVariable)
           {
                System.Console.WriteLine(item);
           }
        }


        public static void  PrintNewMassage(string message)
        {
            System.Console.WriteLine(message);
        }
    }


    
}
