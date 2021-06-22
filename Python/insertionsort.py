def insertion_sort(arr):
    for i in range(1,len(arr)):
        # These are for readability purposes
        currentvalue = arr[i]
        position = i

        while position > 0 and arr[position - 1] > currentvalue: # arr[i]

            arr[position] = arr[position - 1]
            position -= 1   # i

        arr[position] = currentvalue