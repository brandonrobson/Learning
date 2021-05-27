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

def balance_check(string):

    # Edge Check: If the number of brackets is odd we already know it can't be balanced
    if len(string) % 2 != 0:
        return False

    # A set of all the possible opening brackets
    opening = set('([{')
    # We create a set, that takes in a list, which takes in 3 tuples, one for each type of bracket
    matches = set([ ('(',')') , ('[',']') , ('{','}') ])

    # A default list can act as a stack, but we will use our own
    stack = Stack()
    
    # If it's an opening bracket, put it in the stack
    for bracket in string:
        if bracket in opening:
            stack.push(bracket)
        else:
            # If not, check that the stack is not empty
            if stack.isEmpty():
                return False
            # Next, we pop the item and store it
            last_open = stack.pop()

            # If this item isn't one of our brackets we return false
            if(last_open, bracket) not in matches:
                return False
    
    return stack.isEmpty()

print(balance_check('[](){([[[]]])}'))  # Should return True
print(balance_check('()(){]}'))         # Should return False

