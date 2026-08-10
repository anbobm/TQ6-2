using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Fluege;

public class DetailsModel : PageModel
{
    private readonly FlightService _flightService;

    public Flug? Flug { get; private set; }

    public DetailsModel(FlightService flightService)
    {
        _flightService = flightService;
    }

    public IActionResult OnGet(int id)
    {
        Flug = _flightService.GetFlugById(id);

        if (Flug is null)
        {
            return NotFound();
        }

        return Page();
    }
}