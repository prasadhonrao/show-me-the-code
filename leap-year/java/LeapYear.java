import java.util.Scanner;

public class LeapYear {
    public static void main(String[] args) {
        System.out.println("--- Leap Year ---");

        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter a number: ");
        var year = scanner.nextInt();

        if (isLeapYear(year) == true)
            System.out.println("You have entered year " + year + " which is a leap year");
        else
            System.out.println("You have entered year " + year + " which is not a leap year");

        scanner.close();
    }

    static boolean isLeapYear(int year) {
        if ((year % 400 == 0) || (year % 100 != 0) && (year % 4 == 0))
            return true;
        else
            return false;
    }

}
