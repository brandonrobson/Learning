# This function compresses strings by converting repeating characters to characters and numbers
# eg AAAABBBBCCCC becomes A4B4C4

def compress(string):
    r = ""
    length = len(string)

    # Edge Case 1
    if length == 0:
        return ""

    # Edge Case 2
    if length == 1:
        return string + "1"

    last = string[0]
    count = 1
    i = 1

    while i < length:

        if string[i] == string[i - 1]:
            count += 1
        else:
            r = r+ string[i-1] + str(count)

        i += 1
    r = r+ string[i-1] + str(count)

    return r