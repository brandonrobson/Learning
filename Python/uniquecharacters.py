# This algorithm returns a true or false depending on if a string has all unique characters
# eg abcde -> TRUE and aabcde -> FALSE


# This one is the simplist, it compares a set of all the characters withe the length of the
# string. eg if the string was aaabbcde the set would be 'abcde' a length of 5 and the raw
# string would be a length of 8, thus it returns false
def uni_char1(string):
    return len(set(string)) == len(string)

# This one is easier to understand at the expense of efficiency. It creates a set, then it inputs
# each letter individually into the set, if the letter has been seen before it returns FALSE. 
# Otherwise it's allowed to finish all iterations and return TRUE
def uni_char2(string):
    chars = set()

    for letter in string:
        if letter in chars:
            return False
        else:
            chars.add(letter)
    return True