# An unordered sequential search is inefficient on average having a BigO of n (linear)

def seq_search_uo(lst, element):
    
    i = 0
    found = False

    while i < len(lst) and not found:

        if lst[i] == element:
            found = True
        else:
            i += 1

lst = [2,1,5,3,4]
seq_search_uo(lst, 3)
seq_search_uo(lst, 6)

# The difference here is that when the index is on a value more than the one we're searching for we know we have to stop
def seq_search_o(lst,element):

    i = 0
    found = False
    stopped = False

    while i < len(lst) and not found and not stopped:

        if lst[i] == element:
            found = True

        else:
            if lst[i] > element:
                stopped = True

            else:
                i += 1

    return found
    
lst = [1,2,3,4,5,6,7,8,9,10]
seq_search_o(lst, 12)
