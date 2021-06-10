class BinaryTree(object):

    def __init__(self, rootObj):

        self.key = rootObj  # root object is often referred to as the key
        self.leftChild = None
        self.rightChild = None


    def insertLeft(self,newNode):
        
        # If there isn't already a left child, then add it
        if self.leftChild == None:
            self.leftChild = BinaryTree(newNode)
        else:
        # If there IS a left child, add a new node and push it below it
            t = BinaryTree(newNode)
            t.leftChild = self.leftChild
            self.leftChild = t

    def insertRight(self,newNode):
                # If there isn't already a right child, then add it
        if self.rightChild == None:
            self.rightChild = BinaryTree(newNode)
        else:
        # If there IS a right child, add a new node and push it below it
            t = BinaryTree(newNode)
            t.rightChild = self.leftChild
            self.rightChild = t

        
    def getLeftChild(self):
        return self.leftChild

    def getRightChild(self):
        return self.rightChild

    
    def setRootVal(self,obj):
        self.key = obj

    def getRootVal(self):
        return self.key


r = BinaryTree('a')
print(r.getRootVal())
print(r.getLeftChild())
r.insertLeft('b')
print(r.getLeftChild().getRootVal())  # Need getRootVal or you get the memory address.