public class Company
{
    public string? NameCompany { get; set; }
    public int? CompanyId { get; set; }
    public int? NumberOfWorkers { get; set; }

    public string Info()
    {
        return $" ����� ������:{NameCompany},\n ����� ������: {CompanyId},\n ʳ������ ����������: {NumberOfWorkers}";
    }
}