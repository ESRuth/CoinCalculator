using CoinCalculator.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly CoinService _coinService;

    public IndexModel(CoinService coinService)
    {
        _coinService = coinService;
    }

    [BindProperty]
    public decimal Amount { get; set; }

    public string? ErrorMessage { get; set; }

    public Dictionary<string, int>? CoinResult { get; set; }

    public void OnPost()
    {
        if (Amount <= 0)
        {
            ErrorMessage = "Please enter a positive dollar amount.";
            return;
        }

        var service = new CoinService();
        CoinResult = _coinService.GetOptimalCoins(Amount);
    }
}
