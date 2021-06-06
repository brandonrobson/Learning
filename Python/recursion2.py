# String reversing using recursion

def reverse(string):
    # Base Case
    if(len(string) <= 1):
        return string
    
    # Recursion
    return reverse(string[1:]) + string[0]

# The way this works:
# hello -> ello h   (1st function call)
# ello -> llo e h   (2nd function call)
# llo -> lo l e h   (3rd function call)
# lo -> o l l e h   (4th function call)
# return olleh      (5th function call) <- because now the string length is 1 meeting the base case
print(reverse('hello'))