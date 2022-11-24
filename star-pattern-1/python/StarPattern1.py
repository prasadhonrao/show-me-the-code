def main():
    number = int(input('Enter a number: '))

    if (number <= 0):
        print('Invalid input. Please enter a positive number greater than zero.')
    else:
        print('You have entered number:', number)
        for i in range(1, number + 1):
            print(i * '* ')

if __name__ == '__main__':
    print('--- Star Pattern 1 ---')
    main()