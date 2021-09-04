using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

// En proyectos de estilo SDK como este, varios atributos de ensamblado que definían
// en este archivo se agregan ahora automáticamente durante la compilación y se rellenan
// con valores definidos en las propiedades del proyecto. Para obtener detalles acerca
// de los atributos que se incluyen y cómo personalizar este proceso, consulte https://aka.ms/assembly-info-properties


// Al establecer ComVisible en false, se consigue que los tipos de este ensamblado
// no sean visibles para los componentes COM. Si tiene que acceder a un tipo en este
// ensamblado desde COM, establezca el atributo ComVisible en true en ese tipo.

[assembly: ComVisible(false)]

// El siguiente GUID es para el identificador de typelib, si este proyecto se expone
// en COM.

[assembly: Guid("1bfea2c4-00c8-4a6f-95d2-4ebed6b84129")]

namespace rpc_users_page.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 6)]
        public string Username { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 8)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Lastname { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthdate { get; set; }
    }
}