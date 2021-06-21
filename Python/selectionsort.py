def selection_sort(arr):
    for fillslot in range(len(arr)-1,0,-1): #Same thing as bubble sort
        positionOfMax = 0                   # Keep track of position of Max
        for location in range(1,fillslot+1):
            if arr[location] > arr[positionOfMax]:  # Find max
                positionOfMax = location            

        temp = arr[fillslot]                        # Switch max with whatever is in the max slot
        arr[fillslot] = arr[positionOfMax]
        arr[positionOfMax] = temp