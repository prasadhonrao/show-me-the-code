def main():
    first_number = int(input('Enter first number: '))
    second_number = int(input('Enter second number: '))
    swap_numbers_using_third_number(first_number, second_number)
    swap_numbers_without_using_third_number(first_number, second_number)

def swap_numbers_using_third_number(first_number, second_number):
    print('Swapping numbers using a third variable...')
    
    temp = first_number
    first_number = second_number
    second_number = temp

    print(f'First number is: {first_number}')
    print(f'Second number is: {second_number}')

def swap_numbers_without_using_third_number(first_number, second_number):
    print('Swapping numbers without using a third variable...')
    
    first_number = first_number + second_number
    second_number = first_number - second_number
    first_number = first_number - second_number

    print(f'First number is: {first_number}')
    print(f'Second number is: {second_number}')
    
if __name__ == "__main__":
    main()