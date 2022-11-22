import java.util.Scanner;

public class SwapNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter first number: ");
        var firstNumber = scanner.nextInt();

        System.out.print("Enter second number: ");
        var secondNumber = scanner.nextInt();

        swapNumbersUsingThirdVariable(firstNumber, secondNumber);
        swapNumbersWithoutUsingThirdVariable(firstNumber, secondNumber);

        scanner.close();
    }

    static void swapNumbersUsingThirdVariable(int firstNumber, int secondNumber) {
        System.out.println("Swapping numbers using a third variable");

        var temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;

        System.out.println("First number is:" + firstNumber);
        System.out.println("Second number is:" + secondNumber);
    }

    static void swapNumbersWithoutUsingThirdVariable(int firstNumber, int secondNumber) {
        System.out.println("Swapping numbers without using a third variable");

        firstNumber = firstNumber + secondNumber;
        secondNumber = firstNumber - secondNumber;
        firstNumber = firstNumber - secondNumber;

        System.out.println("First number is:" + firstNumber);
        System.out.println("Second number is:" + secondNumber);
    }

}