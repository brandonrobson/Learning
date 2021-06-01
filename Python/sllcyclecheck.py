# For this problem we want to detect whether a linked list is circular or not, meaning the tail
# doesn't loop round to the head

class Node(object):

    def __init__(self, value):
        self.value = value
        self.next_node = None

def cycle_check(node):

    # To do this, we picture a circular linked list like a racing track, so we make 2 racers
    # racer 1 moves 1 element per iteration and racer 2 moves 2.
    # When racer 2 inevitably laps racer 1 it will eventually be equal
    marker1 = node
    marker2 = node

    # While the marker hasn't reached a tail of a non circular linked list (None)
    while marker2 != None and marker2 .next_node != None:
        
        marker1 = marker1.next_node             # Move m1 by 1 
        marker2 = marker2.next_node.next_node   # Move m2 by 2

        # In order to be equal, m2 must have lapped m1 thus it is circular
        if marker2 == marker1:
            return True
    
    # If m2 never laps then it is not circular
    return False
