def permute(string):
    output = []
    # Base Case:
    if len(string) == 1:
        output = string
    else:
        # Recursion: 
        # For every letter in string
        for i,letter in enumerate(string):
            # For every permutation resulting from Step 2 and 3
            for perm in permute(string[:i] + string[i+1:]):
                # Add it to the output
                output += [letter + perm]

    return output

# Honestly I have no clue how any of this works