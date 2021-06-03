class Node(object):

    def __init__(self,value):
        self.value = value
        self.nextnode = None

def nth_to_last_node(n,head):

    left_pointer = head
    right_pointer = head

    for i in range(n-1):

        # If we're at the end of the list

        # Edge case: n is larger than list
        if not right_pointer.nextnode:
            raise LookupError('Error: n is larger than the linked list')
        
        # rp += 1 basically
        right_pointer = right_pointer.nextnode

    # While we're not at the end of the list
    while right_pointer.nextnode:
        # lp += 1
        left_pointer = left_pointer.next_node
        # rp += 1
        right_pointer = right_pointer.next_node
    # The way this works out, rp starts at n-1 of the list so while lp simaltaneously increases
    # eventually rp is going to reach the end, when rp reaches the end, lp will be on the nTh from
    # last node
    return left_pointer