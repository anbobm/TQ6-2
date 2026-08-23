using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Buchungen;

public class IndexModel : PageModel
{
    private readonly BookingService _bookingService;
    private readonly FlightService _flightService;

    public IReadOnlyList<Buchung> Buchungen { get; private set; } =
        Array.Empty<Buchung>();

    public IndexModel(
        BookingService bookingService,
        FlightService flightService)
    {
        _bookingService = bookingService;
        _flightService = flightService;
    }

    public void OnGet()
    {
        Buchungen = _bookingService.GetAlleBuchungen();
    }

    public Kunde? GetKunde(int kundeId)
    {
        return _bookingService.GetKundeById(kundeId);
    }

    public Flug? GetFlug(int flugId)
    {
        return _flightService.GetFlugById(flugId);
    }

    public IActionResult OnPostStornieren(int id)
    {
        if (!_bookingService.StorniereBuchung(id))
        {
            return NotFound();
        }

        return RedirectToPage();
    }


      
      public IActionResult OnPostCheckIn(int id)
{
    if (!_bookingService.CheckInBuchung(id))
    {
        TempData["Fehlermeldung"] =
            "Online Check-in ist nur zwischen 24 und 1 Stunde vor Abflug möglich.";
    }

    return RedirectToPage();
}

}