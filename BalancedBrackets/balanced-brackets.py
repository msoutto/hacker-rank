# Implementation of Balanced Brackets problem
# https://www.hackerrank.com/challenges/balanced-brackets/problem

import sys


# Complete the isBalanced function below.
def isBalanced(s):
    # Dict to keep matches of openning brackets
    matches = {'{': '}', '[': ']', '(': ')'}

    # Odd strings are not balanced, since balanced brackets are paired
    if len(s) % 2 != 0:
        return 'NO'

    # Loop through half of the string, looking for the matching bracket
    for i in range(int(len(s) / 2)):
        if matches[s[i]] != s[len(s) - (i + 1)]:
            return 'NO'

    # If it looped through both halfs of the string
    # and found all the bracket pairs, it is balanced
    return 'YES'


if __name__ == '__main__':
    fptr = sys.stdout

    t = int(input())

    for t_itr in range(t):
        s = input()

        result = isBalanced(s)

        fptr.write(result + '\n')

    fptr.close()
