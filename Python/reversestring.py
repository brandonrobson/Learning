def reverse(message):
    translated = ''
    # i is set to the last element in the string
    i = len(message) - 1

    # This is run while i is still counting down and within the bounds of the array
    while i >= 0:
        # Each character including spaces is added backwards thus reversing the string.
        translated = translated + message[i]
        i = i - 1

    print(translated)
