using System;
using System.Collections.Generic;
using back_piviii.DAL.DTO;
using back_piviii.DAL.DAO;
using back_piviii.BLL.Exceptions;
using back_piviii.DAL.Model;

namespace back_piviii.BLL
{
    public class UsuarioBLL : IUsuarioBLL
    {
        public readonly IUsuarioDAO _usuarioDAO;

        public UsuarioBLL(IUsuarioDAO usuarioDAO)
        {
            _usuarioDAO = usuarioDAO;
        }

        public void AdicionarUsuario(UsuarioDTO usuarioDTO)
        {
            try
            {
                _usuarioDAO.AdicionarUsuario(usuarioDTO);
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
               
        }

        public void AtualizarUsuario(string IdUsuario, UsuarioDTO usuarioDTO)
        {
            bool hasAny = (_usuarioDAO.ObterUsuarioPorId(IdUsuario)) != null;
            if (!hasAny)
            {
                throw new SystemException("Id do Usuario não Encontrado");
            }

            try
            {
                _usuarioDAO.AtualizarUsuario(IdUsuario, usuarioDTO);
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public void DeletarUsuario(string IdUsuario)
        {
            bool hasAny = (_usuarioDAO.ObterUsuarioPorId(IdUsuario)) != null;
            if (!hasAny)
            {
                throw new SystemException("Id do Usuario não Encontrado");
            }
             
            try
            {
                _usuarioDAO.DeletarUsuario(IdUsuario);
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public List<UsuarioDTO> ObterTodosUsuarios()
        {
            try
            {
                var usuario = _usuarioDAO.ObterTodosUsuarios();
                return usuario;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public UsuarioDTO ObterUsuarioEmail(string Email)
        {
            try
            {
                var usuario = _usuarioDAO.ObterUsuarioEmail(Email);
                return usuario;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public UsuarioDTO ObterUsuarioLogin(string Login)
        {
            try
            {
                var usuario = _usuarioDAO.ObterUsuarioLogin(Login);
                return usuario;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public UsuarioDTO ObterUsuarioPorId(string IdUsuario)
        {
            try
            {
                var usuario = _usuarioDAO.ObterUsuarioPorId(IdUsuario);
                return usuario;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public UsuarioDTO ValidaUsuario(string Login, string Senha)
        {
            try
            {
                var usuario = _usuarioDAO.ValidaUsuario(Login,Senha);
                return usuario;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }
    }
}