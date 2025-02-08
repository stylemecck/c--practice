using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter the number: ");
    int num = int.Parse(Console.ReadLine());
    
    int smallestfactor = 1;
    int largestFactor = num;
    
    for (int x = 1; x <= num; x++ ){
        if (num % x == 0){
            Console.WriteLine(x);
            
            if(x < smallestfactor){
                smallestfactor = x;
            }
            
            if (x > largestFactor){
                largestFactor = x;
            }
        }
    }
    Console.WriteLine("The smallestfactor is: " +smallestfactor);
    Console.WriteLine("The largestFactor is: "+largestFactor);
    Console.ReadLine();
  }
}