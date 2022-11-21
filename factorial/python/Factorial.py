print('Enter a number: ')
user_input = int(input());

original_input = int(user_input) 
factorial = 1

while (user_input > 1):
    factorial = factorial * user_input
    user_input = user_input - 1

print('Factorial of ' + str(original_input) + ' is ' + str(factorial))