using System;
class HelloWorld {
  static void Main() {
    
    Console.WriteLine("Enter the number: ");
    int num = int.Parse(Console.ReadLine());
    
    int largestfactor = num;
    
    if (num % 2 != 0){
        Console.WriteLine("The "+num+" is a prime number ");
    }
    else{
        Console.WriteLine("The number is not a prime number");
        for(int x=1; x<=num; x++ ){
            if(num % 2 == 0){
                if(x > largestfactor){
                    largestfactor = x;
                }
            }
        }
          Console.WriteLine("The largest Factor of the number is: " +largestfactor);
    }   
  }
}