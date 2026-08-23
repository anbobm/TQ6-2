using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Buchungen;

public class BestaetigungModel : PageModel
{
    private readonly BookingService _bookingService;
    private readonly FlightService _flightService;

    public Buchung? Buchung { get; private set; }
    public Kunde? Kunde { get; private set; }
    public Flug? Flug { get; private set; }

    public BestaetigungModel(
        BookingService bookingService,
        FlightService flightService)
    {
        _bookingService = bookingService;
        _flightService = flightService;
    }

    public IActionResult OnGet(int id)
    {
        Buchung = _bookingService.GetBuchungById(id);

        if (Buchung is null)
        {
            return NotFound();
        }

        Kunde = _bookingService.GetKundeById(Buchung.KundeId);
        Flug = _flightService.GetFlugById(Buchung.FlugId);

        return Page();
    }
}