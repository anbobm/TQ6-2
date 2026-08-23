using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Buchungen;

public class ErstellenModel : PageModel
{
    private readonly FlightService _flightService;
    private readonly BookingService _bookingService;

    public IReadOnlyList<Flug> Fluege { get; private set; } =
        Array.Empty<Flug>();

    public int? AusgewaehlteFlugId { get; private set; }

    public ErstellenModel(
        FlightService flightService,
        BookingService bookingService)
    {
        _flightService = flightService;
        _bookingService = bookingService;
    }

    public void OnGet(int? flugId)
    {
        Fluege = _flightService.GetAlleFluege();

        if (flugId.HasValue &&
            _flightService.GetFlugById(flugId.Value) is not null)
        {
            AusgewaehlteFlugId = flugId;
        }
    }

    public IActionResult OnPost(
        string vorname,
        string nachname,
        string email,
        int flugId)
    {
        var flug = _flightService.GetFlugById(flugId);

        if (flug is null)
        {
            return NotFound();
        }

        if (flug.Status == "Storniert")
        {
            return RedirectToPage(
                "/Fluege/Details",
                new { id = flugId });
        }

        var buchung = _bookingService.CreateBuchung(
            vorname,
            nachname,
            email,
            flugId);

        return RedirectToPage(
            "/Buchungen/Bestaetigung",
            new { id = buchung.BuchungId });
    }
}