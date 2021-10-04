using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


//Success from all 7 test cases.

class Solution
{
    public static void Main(string[] args)
    {
        // Read the value, convert it to Int32   
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        
        
        // Check if N is an odd number
        if(N% 2!=0)
        {
            Console.WriteLine("Weird");
        }
    
        // Check if N is even and 2<n<5
        else if (N %2 ==0 && N>2 && N<5)
        {
            Console.WriteLine("Not Weird");
        }
        
        // Check if N is even and 6<n<=20
        else if (N %2 ==0 && N>6 && N<=20)
        {
            Console.WriteLine("Weird");
        }
        
        // Check if N is even and greater than 20
        else if (N%2==0 && N>20)
        {
            Console.WriteLine("Not Weird");
        }
    }
    
   
}


