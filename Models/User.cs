using System.ComponentModel.DataAnnotations;

namespace RPC.Models
{
    public class User
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
       
        [DataType(DataType.Date)] //Con esta línea el usuario sólo ingresa la fecha, descarta ingresar la hora. 
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public string photo { get; set; }

    }
}
