using System;

namespace back_piviii.DAL.DTO
{
    public class UsuarioDTO
    {
        public string IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool PerfilSuper { get; set; }
    }
}