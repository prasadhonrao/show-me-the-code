def main():
    print('Enter a number: ')
    user_input = int(input());

    if user_input < 0:
        print('Invalid user input. Please enter a positive number.')
        return

    original_input = int(user_input) 
    factorial = get_factorial(original_input)

    print('Factorial of ' + str(original_input) + ' is ' + str(factorial))

# Factorial of a number using recursion
def get_factorial(n):
   if n == 1:
       return n
   else:
       return n * get_factorial(n-1)


if __name__ == '__main__':
    main()