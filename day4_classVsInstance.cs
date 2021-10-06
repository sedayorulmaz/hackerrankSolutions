using System;
using System.Collections.Generic;
using System.IO;

class Person {
    public int age;     
	public Person(int initialAge) {
        // Add some more code to run some checks on initialAge
        
        if(initialAge>=0)
        {
            age=initialAge;
        }
         else
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            age = 0;
        }
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console 
        
         if (age < 13)
        {
        Console.WriteLine("You are young.");
        }
        else if (age >= 13 && age < 18)
        {
        Console.WriteLine("You are a teenager.");
        }
        else
        {
        Console.WriteLine("You are old.");
        }
     }

     public void yearPasses() {
        // Increment the age of the person in here
         
        age += 1;
    
     }

static void Main(String[] args) {
