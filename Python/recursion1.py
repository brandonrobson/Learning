def fact(n):
    # Base Case
    if n == 0:
        return 1
    else:
        return n*fact(n-1)

print(fact(5))

def rec_sum(n):
    # Base Case
    if n == 0:
        return 0
    else:
        return n + rec_sum(n-1)

print(rec_sum(4))

def sum_func(n):
    # Base Case
    if len(str(n)) == 1:
        return n
    else:
        return n % 10 + sum_func(n//10)

print(sum_func(4321))

def word_split(phrase, list_of_words,output = None):
    # Base Case
    if output is None:
        output = []
    
    for word in list_of_words:
        
        if phrase.startswith(word):
            
            output.append(word)

            return word_split(phrase[len(word):], list_of_words, output)
    
    return output

print(word_split('ilovedogsJohn',['i','am','a', 'dogs', 'John']))