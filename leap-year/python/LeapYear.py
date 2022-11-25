def main():
    year = int(input('Enter a number: '))

    if year <= 0:
        print('Invalid input. Please enter a positive number greater than zero.')
    else:
        if is_leap_year(year):
            print(f'You have entered year {year} which is a leap year')
        else:
            print(f'You have entered year {year} which is not a leap year')

def is_leap_year(year):
    return True if ((year % 400 == 0) or (year % 100 != 0) and (year % 4 == 0)) else False
    
if __name__ == '__main__':
    print('--- Leap Year ---')
    main()