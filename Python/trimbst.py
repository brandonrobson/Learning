# Given the root of a binary search tree and 2 numbers min and max, trim the tree such that all the numbers
# in the new tree are between min and max (inclusive). The resulting tree should still be a valid binary 
# search tree.
# eg a tree of 1,2,3,4,5,6,7,8,9 with a min of 3 and a max of 7 would turn into 3,4,5,6

# To do this we use postorder traversal and recursion

def trimbst(tree,minVal,maxVal):

    if not tree:
        return

    tree.left = trimbst(tree.left,minVal,maxVal)
    tree.rigth = trimbst(tree.right, minVal, maxVal)

    # If it's within the parameters, it's ok and we return it
    if minVal <= tree.val <= maxVal:
        return tree

    # If it's less than the minimum we trim, we already know everything left of here is less than the min
    if tree.val < minVal:
        return tree.right

    # If it's more than the maximum we trim, we already know everything right of here is more than the max
    if tree.val > maxVal:
        return tree.left