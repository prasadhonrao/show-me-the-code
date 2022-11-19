import java.util.Scanner;

public class Factorial {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Enter a number : ");
        int input = scanner.nextInt();

        int userInput = input;
        long factorial = 1;

        while (input > 0) {
            factorial = factorial * input;
            input = input - 1;
        }
        
        System.out.println("Factorial of " + userInput + " is " + factorial);

        scanner.close();
    }

}
