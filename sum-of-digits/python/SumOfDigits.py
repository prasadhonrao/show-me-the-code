def main():
    number = int(input('Enter a number: '))
    sum = 0

    while number > 0:
        sum = sum + number % 10
        number = number // 10 # Note: // is an integer division operator

    print('Sum of digits:', sum)

if __name__ == '__main__':
    main()