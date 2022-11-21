import java.util.Scanner;

public class EvenOddNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Enter a number: ");
        var input = scanner.nextInt();
        
        if (input % 2 == 0) 
            System.out.println("Entered number " + input + " is an even number.");
        else
            System.out.println("Entered number " + input + " is an odd number.");

        scanner.close();
    }
}