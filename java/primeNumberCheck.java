import java.util.*;

public class primeNumberCheck {
    public static boolean isPrime(int num){
        if (num <= 1) {
            return false;
        }

        for(int i =2 ; i < Math.sqrt(num); i++) {
            if(num % i == 0) {
                return false;
            }
        }
        return true;
    }

    public static void main(String [] args){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the number: ");
        int number = sc.nextInt();
        sc.close();

        if(isPrime(number)){
            System.out.println(number+ " is a prime number.");

        }
        else{
            System.out.println(number+ " is a not a prime number.");
        }
    }
}