def shell_sort(arr):
    sublistcount = len(arr)/2

    while sublistcount > 0:
        for start in range(sublistcount):

            gap_insertion_sort(arr, start, sublistcount)

        sublistcount /= 2
    
def gap_insertion_sort(arr,start,gap):
    for i in range(start+gap, len(arr), gap):

        currentvalue = arr[i]
        position = i

        while position >= gap and arr[position - gap] > currentvalue:

            arr[position] = arr[position - gap]
            position -= gap

        arr[position] = currentvalue