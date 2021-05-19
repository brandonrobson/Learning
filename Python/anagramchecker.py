def anagram(string1,string2):

    # Step 1: Remove any junk from the strings, unnecessary spaces and cases
    string1 = string1.replace(' ', '').lower()
    string2 = string2.replace(' ', '').lower()

    # Step 2: We can immediately declare it's not an anagram if the lenghth of each string isn't equal
    if len(string1) != len(string2):
        return False

    # Step 3: Using a dictionary, keep track of each letter in each string. If a letter doesn't appear
    # in string2 or appears too much or too little then it's not an anagram
    count = {}  

    # Add each letter to a dictionary
    for letter in string1:
        if letter in count:
            count[letter] += 1
        else:
            count[letter] = 1
    
    # If that letter is in the second string, remove it from the count. Whatever remains is proof
    # that the two aren't anagrams.
    for letter in string2:
        if letter in count:
            count[letter] -= 1
        else:
            count[letter] = 1
    
    # If there are letters remaining in count, then the strings aren't anagrams.
    for k in count:
        if count[k] != 0:
            return False
    
    return True