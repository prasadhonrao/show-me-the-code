import java.util.Scanner;

public class SumOfDigits {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter a number: ");
        var input = scanner.nextInt();
        var sum = 0;

        while (input > 0) {
            sum = sum + input % 10;
            input = input / 10;
        }

        System.out.println("Sum of digits: " + sum);

        scanner.close();
    }
}
