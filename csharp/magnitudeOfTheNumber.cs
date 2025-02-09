using System;
class HelloWorld {
  static void Main() {
    
    Console.WriteLine("Enter the number: ");
    int num = int.Parse(Console.ReadLine());
    
    int magnitude = Math.Abs(num);
    Console.WriteLine("The magnitude of "+num+" is: "+magnitude);
    
  }
}