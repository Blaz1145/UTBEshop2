using System.ComponentModel.DataAnnotations;

namespace UTBEshop2.Domain.Entities
{
    public class Product
    {
        [Key] //Primarny kluc teda ID
        public int Id { get; set; }

        [Required] // NOT NULL v databaze
        [StringLength(70)] // obmedzenie dlzky mena
        public string Name { get; set; }

        public string? Description { get; set; } // otaznik nepovinne

        public double Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
/*
    Atribúty v hranatých zátvorkách ([Key], [Required]…) sa volajú Data Annotations.
    Robia dve veci naraz:
    
        1. podľa nich EF Core vytvorí databázu (typy stĺpcov, NULL / NOT NULL)
        
        2. podľa nich MVC validuje formulár 
        
*/