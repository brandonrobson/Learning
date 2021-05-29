# Implementation of a Singly Linked List is a simple concept only requiring one small initialisation function

class Node(object):

    def __init__(self,value):
        
        self.value = value
        # An unassigned next node means it is the tail by default
        self.nextnode = None

a = Node(1) # The parameter will be the VALUE you want stored
b = Node(2)
c = Node(3)
# * indicates heads and tails
a.nextnode = b  # List = a* -> b* -> None
b.nextnode = c  # List = a* -> b -> c* -> None

a.value             # Will return the value of a
a.nextnode.value    # Will return the value of b