import java.util.Scanner;

public class PrimeNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter a number : ");
        int input = scanner.nextInt();

        if (isPrimeNumber(input))
            System.out.println(input + " is a prime number.");
        else
            System.out.println(input + " is a not prime number.");

        scanner.close();

    }

    static boolean isPrimeNumber(int number) {
        boolean IsPrime = true;
        for (int i = 2; i < number; i++) {
            if (number % i == 0)
                IsPrime = false;
        }
        return IsPrime;
    }

}
