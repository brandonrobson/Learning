class Stack(object):

    def __init__(self):
        self.items = []
    
    def isEmpty(self):
        return self.items == []

    def push(self, item):
        self.items.append(item)
    
    def pop(self):
        return self.items.pop()
    
    def peek(self):
        return self.items[len(self.items) - 1]
    
    def size(self):
        return len(self.items)

# Since stacks reverse the elements by nature, we have to reverse the stack at the end in order
# to get the queue format
class Queue2Stacks(object):

    def __init__(self):

        self.instack = Stack()
        self.outstack = Stack()

    def enqueue(self, item):
        # Simply pushes the item into the stack
        self.instack.push(item)

    
    def dequeue(self, item):
        # If the outstack is empty
        if not self.outstack:
            # While the instack is NOT empty
            while self.instack:
                # Push the popped item from instack into the outstack
                self.outstack.push(self.instack.pop())
        # Finally pop the outstack thus double-reversing the stack into a proper queue format
        return self.outstack.pop()