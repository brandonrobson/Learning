# Normal fibonacci (exponential monkaW)
def fib(n):
    if n<= 2:
        f = 1
    else:
        f = fib(n-1) + fib(n-2)
    return f

# Fibonacci using memoization
memo = {}
def fib2(n):
    if n in memo: return memo[n]
    if n<= 2: f = 1
    else: f = fib2(n-1) + fib(n-2)
    memo[n] = f
    return f

# Fibonacci using iteration
def fib3(n):
    a,b = 0,1

    for i in range(n):
        a,b = b,a+b
    return a