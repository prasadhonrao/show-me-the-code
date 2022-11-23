def main():
    number = int(input('Number of elements to generate in the series? : '))
    
    n1 = 0
    n2 = 1

    if number <= 0:
        print('Please enter a positive number')
    
    elif number == 1:
        print(n1)
    
    else:
        for i in range(1, number + 1):
            print(n1)
            nth = n1 + n2
            n1 = n2
            n2 = nth

if __name__ == '__main__':
    main()


# 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 

