namespace ServicesBlazor.Data.Model;

public class CompanyModel
{
    public int Id { get; set; }
    public string Razao { get; set; }
    public string CNPJ { get; set; }

    public ICollection<ServicesModel> Services { get; set; }
}