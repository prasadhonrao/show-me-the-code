import java.util.Scanner;

public class SimpleCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Enter the first number: ");
        var firstNumber = scanner.nextInt();
        
        System.out.print("Enter the second number: ");
        var secondNumber = scanner.nextInt();
        
        System.out.print("Choose operation from + - * / % : ");
        var operation = scanner.next();

        switch (operation) {
            case "+":
                System.out.println(firstNumber + secondNumber);
                break;
            case "-":
                System.out.println(firstNumber - secondNumber);
                break;
            case "*":
                System.out.println(firstNumber * secondNumber);
                break;
            case "/":
                if (secondNumber == 0) {
                    System.out.println("cannot divide by zero");
                    break;
                }
                System.out.println(firstNumber / secondNumber);
                break;
            case "%":
                if (secondNumber == 0) {
                    System.out.println("cannot divide by zero");
                    break;
                }
                System.out.println(firstNumber % secondNumber);
                break;
        }

        scanner.close();
    }    
}
