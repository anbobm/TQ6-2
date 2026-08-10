using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Fluege;

public class IndexModel : PageModel
{
    private readonly FlightService _flightService;

    public IReadOnlyList<Flug> Fluege { get; private set; } = Array.Empty<Flug>();

    public IndexModel(FlightService flightService)
    {
        _flightService = flightService;
    }

    public void OnGet()
    {
        Fluege = _flightService.GetAlleFluege();
    }
}