using Product;

internal class Program
{
    private static void Main(string[] args)
    {
        var response = Productinfo.GetAllProductinfo()
            .Join(Shipmentinfo.GetAllShipmentinfo(),
            pro => pro.id,
            ship => ship.date,
            (pro, ship) => new
            {
               Id = pro.id,
               Name = pro.name,
               Date = ship.date
            }).ToList();

        foreach (var info in response)
        {
            Console.WriteLine($"Id = {info.Id}, Name = {info.Name}, Date = {info.Date}");
        }
    }
}