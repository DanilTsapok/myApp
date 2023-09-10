var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var firstCompany = new Company { NameCompany = "Brightech", CompanyId = 1, NumberOfWorkers = 10000 };
app.MapGet("FirstTask/", () => firstCompany.Info());
app.MapGet("SecondTask/", () =>
{
    var random = new Random();
    int number = random.Next(0, 101);
    return number.ToString();
});

app.Run();