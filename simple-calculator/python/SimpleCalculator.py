print('Enter first number: ')
first_number = int(input());

print('Enter second number: ')
second_number = int(input())

print("Choose operation from + - * / % : ")
operation = input()

# --- Note --- 
# match case keywords are available only in Python 3.10 and above. Use nested if-else statements in earlier versions.
match operation:
    case '+':
        print(first_number + second_number)
    case '-':
        print(first_number - second_number)
    case '*':
        print(first_number * second_number)
    case '/':
        if (second_number == 0):
            print('cannot divide by zero')
        else:    
            print(first_number / second_number)
    case '%':
        if (second_number == 0):
            print('cannot divide by zero')
        else:
            print(first_number % second_number)
    case _:
        print('Invalid operation')