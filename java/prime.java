import java.util.Scanner;

public class prime {
    static void main(String[] args){
        System.out.println("Enter the number: ");
        Scanner sc = new Scanner(System.in);
        int number = sc.nextInt();

        if(number % 2 != 0){
            System.out.println(number+" is a prime number");
        } else {
            System.out.println(number+ "is not a prime number.");
        }
    }
}
