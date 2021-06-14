# We use inorder traversal to check whether the tree is sorted or not, if it is sorted properly
# we return true (left children and less than their parent and right children are more than their parent)

# Basically we take the tree and sort it properly, if the sort is the same as the original,
# then we know it was already sorted and is thus a BST

tree_vals = []

def inorder(tree):
    if tree != None:
        inorder(tree.getLeftChild())
        tree_vals.append(tree.getRootVal())
        inorder(tree.getRightChild())

def sort_check(tree_vals):
    return tree_vals == sorted(tree_vals)

inorder(tree)
sort_check(tree_vals)

# Obviously we need to implement the inorder function as well as a tree funtion

# Another classic solution is to keep track of the minimum and maximum values a node
# can take:

class Node:
    def __init__(self, k, val):
        self.key = k
        self.value = val
        self.left = None
        self.right = None

def tree_max(node):
    if not node:
        return float("-inf")
    maxleft = tree_max(node.left)
    maxright = tree_max(node.right)
    return max(node.key, maxleft, maxright)

def tree_min(node):
    if not node:
        return float("inf")
    minleft = tree_min(node.left)
    minright = tree_min(node.right)
    return min(node.key, minleft, minright)

def verify(node):
    if not node:
        return True
    if (tree_max(node.left) <= node.key <= tree_min(node.rigth) and verify(node.left) and verify(node.right)):
        return True
    else:
        False
    