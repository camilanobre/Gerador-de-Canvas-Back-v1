using back_piviii.DAL.Model;
using back_piviii.DAL.DTO;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;


namespace back_piviii.DAL.DAO
{
    public class UsuarioDAO : IUsuarioDAO
    {
        private readonly IMongoContext _context;

        public UsuarioDAO(IMongoContext context)
        {
            _context = context;
        }

        public void AdicionarUsuario(UsuarioDTO usuarioDTO)
        {
            Usuario novoUsuario = new Usuario
            {
                Nome = usuarioDTO.Nome,
                Login = usuarioDTO.Login,
                Senha = usuarioDTO.Senha,
                Email = usuarioDTO.Email,
                PerfilSuper = usuarioDTO.PerfilSuper
            };
            _context.CollectionUsuario.InsertOne(novoUsuario);
        }

        public void AtualizarUsuario(string IdUsuario, UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario
            {
                IdUsuario = usuarioDTO.IdUsuario,
                Nome = usuarioDTO.Nome,
                Login = usuarioDTO.Login,
                Senha = usuarioDTO.Senha,
                Email = usuarioDTO.Email,
                PerfilSuper = usuarioDTO.PerfilSuper
            };
            _context.CollectionUsuario.ReplaceOne(usu => usu.IdUsuario == IdUsuario, usuario);
        }

        public void DeletarUsuario(string IdUsuario)
        {
            _context.CollectionUsuario.DeleteOne(usu => usu.IdUsuario == IdUsuario);
        }

        public List<UsuarioDTO> ObterTodosUsuarios()
        {
            List<UsuarioDTO> usuarioDTOs = new List<UsuarioDTO>();
            var usuarios = _context.CollectionUsuario.Find<Usuario>(usu => true).ToList();

            foreach (var item in usuarios)
            {
                UsuarioDTO usuarioDTO = new UsuarioDTO
                {
                    IdUsuario = item.IdUsuario,
                    Login = item.Login,
                    Senha = item.Senha,
                    Nome = item.Nome,
                    PerfilSuper = item.PerfilSuper,
                    Email = item.Email
                };
                usuarioDTOs.Add(usuarioDTO);
            }
            return usuarioDTOs;
        }

        public UsuarioDTO ObterUsuarioEmail(string Email)
        {
            var usuarios = _context.CollectionUsuario.Find<Usuario>(usu => usu.Email == Email).FirstOrDefault();

            UsuarioDTO usuarioDTO = new UsuarioDTO
            {
                IdUsuario = usuarios.IdUsuario,
                Login = usuarios.Login,
                Senha = usuarios.Senha,
                Email = usuarios.Email,
                Nome = usuarios.Nome,
                PerfilSuper = usuarios.PerfilSuper,
            };
            return usuarioDTO;
        }

        public UsuarioDTO ObterUsuarioLogin(string Login)
        {
            var usuarios = _context.CollectionUsuario.Find<Usuario>(usu => usu.Login == Login).FirstOrDefault();

            UsuarioDTO usuarioDTO = new UsuarioDTO
            {
                IdUsuario = usuarios.IdUsuario,
                Login = usuarios.Login,
                Senha = usuarios.Senha,
                Email = usuarios.Email,
                Nome = usuarios.Nome,
                PerfilSuper = usuarios.PerfilSuper
            };
            return usuarioDTO;
        }

        public UsuarioDTO ObterUsuarioPorId(string IdUsuario)
        {
            var usuarios = _context.CollectionUsuario.Find<Usuario>(usu => usu.IdUsuario == IdUsuario).FirstOrDefault();

            UsuarioDTO usuarioDTO = new UsuarioDTO
            {
                IdUsuario = usuarios.IdUsuario,
                Login = usuarios.Login,
                Senha = usuarios.Senha,
                Email = usuarios.Email,
                Nome = usuarios.Nome,
                PerfilSuper = usuarios.PerfilSuper
            };
            return usuarioDTO;
        }

        public UsuarioDTO ValidaUsuario(string Login, string Senha)
        {
            var usuarios = _context.CollectionUsuario.Find<Usuario>(usu => true).ToList();

            foreach (var item in usuarios)
            {
                if(item.Login == Login && item.Senha == Senha)
                {
                    UsuarioDTO usuarioDTO = new UsuarioDTO
                    {
                        IdUsuario = item.IdUsuario,
                        Login = item.Login,
                        Senha = item.Senha,
                        Email = item.Email,
                        Nome = item.Nome,
                        PerfilSuper = item.PerfilSuper
                    };
                    return usuarioDTO;
                }
                return null;
            }
            return null;
        }
    }
}
