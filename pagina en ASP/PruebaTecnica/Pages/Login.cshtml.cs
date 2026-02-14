using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PruebaTecnica.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Mensaje { get; set; }

        public void OnPost()
        {
            if (Usuario == "admin" && Password == "1234")
            {
                Mensaje = $"Login correcto. Bienvenido {Usuario}";
            }
            else
            {
                Mensaje = "Usuario o contraseña incorrectos.";
            }
        }
    }
}
