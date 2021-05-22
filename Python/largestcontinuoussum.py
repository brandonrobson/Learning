# What we're trying to do here is take in array 'arr' and count all the elements
# until we find the largest continuous sum we can make. The array will include
# positive and negative integers. 
# This does not mean simply sum all positive integers.
# Say the array was [1, 2, -1, 3, 4, 10, 10, -10, -1]
# The largest sum we can make in order is 29, the first 7 elements. 

def large_cont_sum(arr):

    # Edge case, if the array has no elements, there can't be a sum
    if len(arr) == 0:
        return 0

    max_sum = current_sum = arr[0]

    # We start at 1 onwards as max and current sum are already set to the first element
    for num in arr[1:]:
        # So take the current sum and add the next number, since we want the largest sum we take the max
        current_sum = max(current_sum + num, num)
        # Next we compare the current sum to our max sum, if current sum is bigger then make that the new max sum
        max_sum = max(current_sum, max_sum)
    # After all iterations are complete, return the result which will be the Largest Continuous Sum
    return max_sum