# Iterative
def binary_search(arr,ele):

    first = 0
    last = len(arr) - 1

    found  = False

    while first <= last and not found:

        mid = (first+last)/2

        # If the element we're searching for is the middle by coincidence, return True
        if arr[mid] == ele:
            found = True
        else:
            # If our element is less than the middle element, we disregard the upper half and continue
            if ele < arr[mid]:
                last = mid - 1
            # If our element is more than the middle element, we disregard the lower half and continue
            else:
                first = mid + 1
    return found

# Recursive
def rec_binary_search(arr,ele):

    # Base Case
    if len(arr) == 0:
        return False

    else:
        mid = len(arr) / 2

        # Searched element is the middle
        if arr[mid] == ele:
            return True
        
        else:

            if ele < arr[mid]:
                return rec_binary_search(arr[:mid], ele)    # Lower half searched, upper discarded

            else:
                return rec_binary_search(arr[mid + 1:], ele) # upper half searched, lower discarded