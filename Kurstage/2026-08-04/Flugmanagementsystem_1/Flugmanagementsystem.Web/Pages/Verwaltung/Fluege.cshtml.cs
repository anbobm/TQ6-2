using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Verwaltung;

public class FluegeModel : PageModel
{
    private readonly FlightService _flightService;

    public IReadOnlyList<Flug> Fluege { get; private set; } =
        Array.Empty<Flug>();

    public FluegeModel(FlightService flightService)
    {
        _flightService = flightService;
    }

    public void OnGet()
    {
        Fluege = _flightService.GetAlleFluege();
    }

    public IActionResult OnPostStornieren(int id)
    {
        if (!_flightService.StorniereFlug(id))
        {
            return NotFound();
        }

        return RedirectToPage();
    }
}
