def pair(array, k):

    # If the array is less than two then we can't find pairs
    if len(array) < 2:
        return

    # Sets for tracking
    seen = set()
    output = set()

    # For each number in the array we look for another element which would sum to 'k' for example
    # If k was 5 and we were on element 2 then we're checking the array for 3. If 3 is in it, put
    # it in the output set
    for number in array:
        target = k - number

        if target not in seen:
            seen.add(number)
        else:
            output.add( ((min(number, target)), max(number,target)) )
    
    # This is just a python trick to output each pair neatly, basically just prints the output set
    print('\n'.join(map(str, list(output))))

# Some test data
a = [1,2,3,4,5]
b = 5
pair(a, b)