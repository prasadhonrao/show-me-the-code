def main():
    print('Enter a number: ')
    user_input = int(input());

    if (is_prime_number(user_input)):
        print(f"{user_input} is a prime number.")
    else:
        print(f"{user_input} is a not prime number.")

def is_prime_number(number):
    is_prime = True
    for i in range(2, number):
        if (number % i == 0):
            is_prime = False
    return is_prime

if __name__ == '__main__':
    main()