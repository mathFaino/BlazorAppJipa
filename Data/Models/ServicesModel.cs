using System.ComponentModel.DataAnnotations;

namespace ServicesBlazor.Data.Model;

public class ServicesModel
{
    public int Id { get; set; }
    
    [Required]
    public int CompanyId { get; set; }
    public CompanyModel Company { get; set; }
    
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Nome { get; set; }
    public double ValorSugerido { get; set; }
    public string TempoEstimado { get; set; }
    public string Garantia { get; set; }
    public string Tipo { get; set; }
    
}
