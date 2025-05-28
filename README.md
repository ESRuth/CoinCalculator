# Coin Calculator (Razor Pages + C#)

A simple web application that calculates the optimal combination of US coins for a given dollar amount.

## 🧮 Features

- Input any dollar amount (e.g., 0.99, 1.56, 12.85)
- Calculates:
  - Silver Dollar
  - Half Dollar
  - Quarter
  - Dime
  - Nickel
  - Penny
- Clean UI built with Razor Pages and Bootstrap
- Unit-tested coin calculation logic using xUnit

## 🚀 Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/ESRuth/CoinCalculator.git
   cd CoinCalculator
   ```

2. Run the application:
   ```bash
   dotnet run --project CoinCalculator
   ```

3. Open your browser and visit:
   ```
   http://localhost:5000
   ```

## 🧪 Running Tests

To run the unit tests for the coin optimization logic:

```bash
dotnet test
```

## 📂 Project Structure

```
CoinCalculator/          Razor Pages web app
CoinCalculator.Tests/    Unit tests (xUnit)
CoinCalculator.sln       Solution file
```

## ✍️ Author

Eric Ruth

## Exercise

Create a web page that will display the optimal coin combination (fewest number of coins) that fulfills a given dollar value. The web page should take a dollar value as input and interact with an API that computes and returns the optimal coin combination. The results of the API call should be displayed on the web page. Assume the following coins: - Silver Dollar ($1.00) - Half Dollar (0.50) - Quarter (0.25) - Dime (0.10) - Nickel (0.05) - Penny (0.01)

Input: A dollar value (e.g. $1.56 or $12.85).

Output: A format of your choosing that indicates which coins and how many of each are required. An ideal output for the API is an object in JSON representation of the coins and a count for each coin. For example, your solution should return something like the following for the indicated values:

$0.99 => { "silver-dollar": 0, "half-dollar": 1, "quarter": 1, "dime": 2, "nickel": 0, "penny": 4 }

$1.56 => { "silver-dollar": 1, "half-dollar": 1, "quarter": 0, "dime": 0, "nickel": 1, "penny": 1 }

$12.85 => { "silver-dollar": 12, "half-dollar": 1, "quarter": 1, "dime": 1, "nickel": 0, "penny": 0 }

At a minimum the above examples should work.

Solution should feature readability, clean and articulate coding, some creativity, and pragmatism.

Bonus points are rewarded for a unit test and demonstrating client-side skills with a nice UX presentation. 
