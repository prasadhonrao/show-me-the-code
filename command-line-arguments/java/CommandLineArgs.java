public class CommandLineArgs {
    public static void main(String[] args) {
        if (args.length == 0) 
            System.out.println("No command line arguments were specified");
        else {
            for (String arg : args) {
                System.out.println(arg);
            }
        }
    }    
}
