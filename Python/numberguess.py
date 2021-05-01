import random

num = random.randint(0, 100)
wrongGuess = True

print('Psst, the correct number is '+ str(num) +'. ForsenCD')

while wrongGuess:
    user = input('Enter your guess: ')
    if int(user) == num:
        print('Number is correct')
        break
    elif int(user) > num:
        print('Lower')
    else:
        print('Higher')