# This function is very inefficient 

def rec_coin(target, coins):
    
    # DEFAULT VALUE SET TO TARGET
    min_coins = target
    # BASE CASE CHECKS TO SEE IF TARGET IS IN COIN VALUES LIST
    if target in coins:
        return 1
    else:
        # For every coin value that is <= my target value
        for i in [coin for coin in coins if coin <= target]:    # This look horrible, look up list comprehension
            # ADD A COIN COUNT (1) TO RECURSIVE and subtract that coin from the target (target 25, coin 10 so new target 15)
            num_coins = 1 + rec_coin(target - i, coins)
            # RESET THE MINIMUM IF THE NEW NUM_COINS LESS THAN MIN_COINS
            if num_coins < min_coins: 
                min_coins = num_coins

    return min_coins