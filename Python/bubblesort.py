# Obviously since we have two nested for loops, the Big O is quadratic! O(n^2) - very bad!

def bubble_sort(arr):
    for n in range(len(arr) - 1, 0, -1):    # Basically iterates the array backwards, minus the last element eg 12345 -> 4321
        for k in range(n):                  # k is just an index for the values we're actually checking k = item 1, k + 1 = item 2
            # Compare the two items... if item 1 is bigger than item 2 we switch them
            if arr[k] > arr[k+1]:
                temp = arr[k]       # Temporarily store item 1
                arr[k] = arr[k+1]   # Change item 1 to item 2
                arr[k+1] = temp     # Change item 2 to our temp which is item 1 completing the switch