import sys

if (len(sys.argv) == 0):
    print('No command line arguments were specified')
else:
    # Note:
    # sys.argv[0] is the first argument represents the script name, hence starting the loop with index 1
    for arg in range(1, len(sys.argv)):
        print(arg)