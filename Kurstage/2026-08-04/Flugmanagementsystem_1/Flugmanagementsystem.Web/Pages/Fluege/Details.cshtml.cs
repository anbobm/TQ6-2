using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Fluege;

public class DetailsModel : PageModel
{
    private readonly FlightService _flightService;
    private readonly BookingService _bookingService;

    public Flug? Flug { get; private set; }

    public int AnzahlAktiverBuchungen { get; private set; }

    public decimal GesamtGepaeckgewicht { get; private set; }

    public DetailsModel(
        FlightService flightService,
        BookingService bookingService)
    {
        _flightService = flightService;
        _bookingService = bookingService;
    }

    public IActionResult OnGet(int id)
    {
        Flug = _flightService.GetFlugById(id);

        if (Flug is null)
        {
            return NotFound();
        }

        AnzahlAktiverBuchungen =
            _bookingService.GetAnzahlAktiverBuchungenByFlugId(Flug.FlugId);

        GesamtGepaeckgewicht =
            _bookingService.GetGesamtGepaeckgewichtByFlugId(Flug.FlugId);

        return Page();
    }
}