using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTBEshop2.Domain.Entities
{
    [Table(nameof(Product))] //vdaka tomuto sa bude volat objekt Product a nie Products ako v DbSet
                             /* pomocou "dotnet ef migrations add mysql_1.0.0_init_product --project UTBEshop2.Infrastructure --startup-project UTBEshop2.Web"
                                vytvorime migraciu*/
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