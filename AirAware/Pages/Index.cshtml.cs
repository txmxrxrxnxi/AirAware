using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AirAware.Pages;


public class IndexModel
    : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(
        ILogger<IndexModel> logger)
    {
        _logger = logger;
        return;
    }

    public void OnGet()
    {
        return;
    }
}
