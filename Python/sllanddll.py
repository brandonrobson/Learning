# Simply implement a singly linked list and doubly linked list

class NodeSLL(object):

    def __init__(self, value):

        self.value = value
        self.nextnode = None

class NodeDLL(object):

    def __init__(self,value):

        self.value = value
        self.nextnode = None
        self.prevnode = None


sA = NodeSLL(1)
sB = NodeSLL(2)
sC = NodeSLL(3)
sD = NodeSLL(4)

sA.nextnode = sB
sB.nextnode = sC
sC.nextnode = sD

dA = NodeDLL(1)
dB = NodeDLL(2)
dC = NodeDLL(3)
dD = NodeDLL(4)

dA.nextnode = dB
dB.nextnode = dC
dC.nextnode = dD
dB.prevnode = dA
dC.prevnode = dB
dD.prevnode = dC