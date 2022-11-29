import java.util.Scanner;

public class FactorialRecursion {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter a number : ");
        int input = scanner.nextInt();

        if (input < 0) {
            System.out.println("Invalid user input. Please enter a positive number.");
            scanner.close();
            return;
        }

        int userInput = input;
        long factorial = calculateFactorial(userInput);

        System.out.println("Factorial of " + userInput + " is " + factorial);

        scanner.close();
    }

    static long calculateFactorial(int number) {
        if (number == 0) {
            return 1;
        } else if (number == 1) {
            return number;
        } else {
            return calculateFactorial(number - 1) * number;
        }
    }

}
