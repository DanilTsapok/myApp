public class Company
{
    public string? NameCompany { get; set; }
    public int? CompanyId { get; set; }
    public int? NumberOfWorkers { get; set; }

    public string Info()
    {
        return $" Назва компанії:{NameCompany},\n Номер компанії: {CompanyId},\n Кількість працівників: {NumberOfWorkers}";
    }
}