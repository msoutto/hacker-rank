# Implementation of binary tree challenge (EASY)
# https://www.hackerrank.com/challenges/tree-height-of-a-binary-tree/problem


class Node:
    def __init__(self, info):
        self.info = info
        self.left = None
        self.right = None
        self.level = None

    def __str__(self):
        return str(self.info)


class BinarySearchTree:
    def __init__(self):
        self.root = None

    def create(self, val):
        if self.root is None:
            self.root = Node(val)
        else:
            current = self.root

            while True:
                if val < current.info:
                    if current.left:
                        current = current.left
                    else:
                        current.left = Node(val)
                        break
                elif val > current.info:
                    if current.right:
                        current = current.right
                    else:
                        current.right = Node(val)
                        break
                else:
                    break


def levelOrder(root):
    current = root
    to_visit = [current]
    visited = []

    while len(to_visit) > 0:
        current = to_visit.pop(0)
        if current not in visited:
            visited.append(current.info)
        if current.left:
            to_visit.append(current.left)
        if current.right:
            to_visit.append(current.right)
    return visited


tree = BinarySearchTree()
t = int(input('Enter size of tree: '))

arr = list(map(int, input('Enter nodes: ').split(' ')))
for i in range(t):
    tree.create(arr[i])

print(levelOrder(tree.root))
