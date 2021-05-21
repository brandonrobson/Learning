# All of these methods do the same thing in different ways/efficiencies

# O(nlogn) method
def finder1(array1,array2):
    array1.sort()
    array2.sort()

    # A zip just combines two arrays, so the first element of arr1 and arr2 are kept in a pair.
    # Since we sorted them, they should be the same, then when we find one that doesn't match
    # then that is the missing element
    for num1, num2 in zip(array1,array2):
        if num1 != num2:
            return num1

    return array1[-1]


# My method O(n)
def finder2(array1, array2):
    for n in array1:
        total1 += array1[n]
    for n in array2:
        total2 += array2[n]

    if total1 == total2:
        print('No missing element!')
    else:
        missing = total1 - total2
    
    print(missing + ' is the missing element!')


# My method but more efficient
def finder3(arr1,arr2):
    return abs(sum(arr1)-sum(arr2))


# Jose's method O(n)
import collections
def finder4(arr1,arr2):
    d = collections.defaultdict(int)

    for num in arr2:
        d[num] += 1

    for num in arr1:
        if d[num] == 0:
            return num
        else:
            d[num] -= 1

# Jose's method 2, similar to mine
def finder5(arr1,arr2):
    result = 0

    # Perform an XOR between the numbers in the arrays:
    for num in arr1+arr2:
        result^=num
        print(result)

    return result
        