# CoinCalculator

The exercise shouldn't take too long. If you would, please record the time you start and the time you finish. Please include these times in your solution response. The front-end can be React, Angular, or Razor Pages. These need to access a C# method responsible for handling the coin optimization. Here's a bit more detail:

Create a web page that will display the optimal coin combination (fewest number of coins) that fulfills a given dollar value. The web page should take a dollar value as input and interact with an API that computes and returns the optimal coin combination. The results of the API call should be displayed on the web page. Assume the following coins: - Silver Dollar ($1.00) - Half Dollar (0.50) - Quarter (0.25) - Dime (0.10) - Nickel (0.05) - Penny (0.01)
Input: A dollar value (e.g. $1.56 or $12.85).
Output: A format of your choosing that indicates which coins and how many of each are required. An ideal output for the API is an object in JSON representation of the coins and a count for each coin. For example, your solution should return something like the following for the indicated values:
$0.99 => { "silver-dollar": 0, "half-dollar": 1, "quarter": 1, "dime": 2, "nickel": 0, "penny": 4 }
$1.56 => { "silver-dollar": 1, "half-dollar": 1, "quarter": 0, "dime": 0, "nickel": 1, "penny": 1 }
$12.85 => { "silver-dollar": 12, "half-dollar": 1, "quarter": 1, "dime": 1, "nickel": 0, "penny": 0 }
At a minimum the above examples should work.
Solution should feature readability, clean and articulate coding, some creativity, and pragmatism.
Bonus points are rewarded for a unit test and demonstrating client-side skills with a nice UX presentation.