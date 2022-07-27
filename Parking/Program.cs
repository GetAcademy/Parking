using System.Text.Json;
using Parking;

var parkingAreasJson = File.ReadAllText("parkeringsomraade.json");
var parkingAreas = JsonSerializer.Deserialize<ParkingArea[]>(parkingAreasJson);


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.MapGet("/parkingWithShower", () =>
{
    var areas = new List<ParkingArea>();
    foreach (var parkingArea in parkingAreas)
    {
        if (parkingArea.hasShower)
        {
            areas.Add(parkingArea);
        }
    }

    return areas;
});
app.Run();
