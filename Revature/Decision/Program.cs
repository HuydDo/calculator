﻿using System;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int a = 10;
            if (a < 20){
              Console.WriteLine("a is less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
            Console.ReadLine(); */

            // int a = 100;
            // if (a < 20){
            //   Console.WriteLine("a is a less than 20");
            // } else {
            //   Console.WriteLine("a is not less than 20");
            // }
            // Console.WriteLine("value of a is : {0}", a);
            // Console.ReadLine();

            //* local variable definition */
          //  int a = 100;
          //  int b = 200;
           
          //  /* check the boolean condition */
          //  if (a == 100) {
              
          //     /* if condition is true then check the following */
          //     if (b == 200) {
          //        /* if condition is true then print the following */
          //        Console.WriteLine("Value of a is 100 and b is 200");
          //     }
          //  }
          //  Console.WriteLine("Exact value of a is : {0}", a);
          //  Console.WriteLine("Exact value of b is : {0}", b);
          //  Console.ReadLine(); 

        int a = 100;
         int b = 200;
         
         switch (a) {
            case 100: 
            Console.WriteLine("This is part of outer switch ");
            
            switch (b) {
               case 200:
               Console.WriteLine("This is part of inner switch ");
               break;
            }
            break;
         }
         Console.WriteLine("Exact value of a is : {0}", a);
         Console.WriteLine("Exact value of b is : {0}", b);
         Console.ReadLine();
      }
   }
}
