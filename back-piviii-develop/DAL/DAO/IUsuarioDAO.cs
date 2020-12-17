using System.Collections.Generic;
using back_piviii.DAL.DTO;
using back_piviii.Extensions.Responses;

namespace back_piviii.DAL.DAO
{
    public interface IUsuarioDAO
    {
        List<UsuarioDTO> ObterTodosUsuarios();
        UsuarioDTO ObterUsuarioPorId(string IdUsuario);
        UsuarioDTO ObterUsuarioEmail(string Email);
        UsuarioDTO ObterUsuarioLogin(string Login);

        void AdicionarUsuario(UsuarioDTO usuarioDTO);
        void AtualizarUsuario(string IdUsuario,UsuarioDTO usuarioDTO);
        void DeletarUsuario(string IdUsuario);

        UsuarioDTO ValidaUsuario(string Login, string Senha);
    }
}
