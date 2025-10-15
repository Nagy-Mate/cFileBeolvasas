using fileRead;


var fileReader = new FileReader();
var books = fileReader.ListBooks();
var kesedelmek = new Dictionary<int, int>();
foreach (var b in books)
{
    var kesedelem = b.EndDate - b.StartDate;
    var kesedelemNap =  kesedelem.Days;
    kesedelmek.Add(b.Id, kesedelemNap);
}
var maxKesedelem = kesedelmek.MaxBy(k => k.Value);
var ki = books.FirstOrDefault(b => b.Id == maxKesedelem.Key).KolcsonzoId;
var mennyit = (maxKesedelem.Value - 30) * 100;
if(mennyit > 0)
{
    Console.WriteLine($"Kölcsönző id: {ki}, {mennyit} ft-al késik");
}
