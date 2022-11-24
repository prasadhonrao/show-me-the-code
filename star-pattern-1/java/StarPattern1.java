import java.util.Scanner;

public class StarPattern1 {
    public static void main(String[] args) {
        System.out.println("--- Star Pattern 1 ---");

        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter a number: ");
        var input = scanner.nextInt();

        if (input <= 0)
            System.out.println("Invalid input. Please enter a positive number greater than zero.");
        else {
            System.out.println("You have entered number: " + input);
            for (int i = 1; i <= input; i++) {
                for (int j = 1; j <= i; j++)
                    System.out.print("* ");
                System.out.println("\t");
            }
        }

        scanner.close();
    }
}