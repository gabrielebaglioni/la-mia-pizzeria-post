namespace la_mia_pizzeria_model.Models;

public class Pizza
{
    
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Photo { get; set; }
    public decimal Price { get; set; }
}