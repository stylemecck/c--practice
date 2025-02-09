using System;
public class PrimeCheck {
     static void Main(){
        Console.WriteLine("Enter the number:");
        int num = int.Parse(Console.ReadLine());
        
        int largestFactor = num;
        int  smallestFactor = 1;
        
        if(num <= 1){
            Console.WriteLine(num+" is not a prime number.");
        } else if(num == 2){
            Console.WriteLine(num+" is  a prime number");
        } else if(num > 2 && num % 2 != 0){
            Console.WriteLine(num+" is a prime number.");
        } else {
             Console.WriteLine(num+" is not a prime number.");
            for(int x = 1; x <= num; x++){
                if(num % x == 0){
                   if (x < smallestFactor){
                       smallestFactor = x;
                   }
                   if(x > largestFactor) {
                       largestFactor = x;
                   }
                }
            }
            Console.WriteLine("The smallest Factor "+num+ " is " +smallestFactor);
            Console.WriteLine("The Largest Factor "+num+ " is " +largestFactor);
        }
        
     }
}