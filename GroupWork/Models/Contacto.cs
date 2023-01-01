using System.ComponentModel.DataAnnotations;

namespace GroupWork.Models
{
    public class Contacto
    {
        
            public int Id { get; set; }
            public string? Name { get; set; }
            [DataType(DataType.Date)]
            public DateTime Birthdate { get; set; }
            public int Number { get; set; }
        
    }
}
