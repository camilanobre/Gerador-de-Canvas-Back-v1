using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using back_piviii.DAL.DTO;
using back_piviii.DAL.Model;
using back_piviii.BLL;

namespace back_piviii.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioBLL _usuarioBLL;

        public UsuarioController(IUsuarioBLL usuarioBLL)
        {
            _usuarioBLL = usuarioBLL;
        }

        [HttpPost("AdicionarUsuario")]
        public ActionResult<Usuario> AdicionarUsuario(UsuarioDTO usuarioDTO)
        {
            try
            {
                _usuarioBLL.AdicionarUsuario(usuarioDTO);
                return Ok();
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpPut("AtualizarUsuario/{IdUsuario}")]
        public ActionResult<Usuario> AtualizarUsuario(string IdUsuario,UsuarioDTO usuarioDTO)
        {
            try
            {
                _usuarioBLL.AtualizarUsuario(IdUsuario,usuarioDTO);
                return Ok();
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpDelete("DeletarUsuario/{IdUsuario}")]
        public ActionResult<Usuario> DeletarUsuario(string IdUsuario)
        {
            try
            {
                _usuarioBLL.DeletarUsuario(IdUsuario);
                return Ok();
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ObterUsuarioPorId/{IdUsuario}")]
        public ActionResult<Usuario> ObterUsuarioPorId(string IdUsuario)
        {
            try
            {
                return Ok(_usuarioBLL.ObterUsuarioPorId(IdUsuario));
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ObterUsuarioEmail/{Email}")]
        public ActionResult<Usuario> ObterUsuarioEmail(string Email)
        {
            try
            {
                return Ok(_usuarioBLL.ObterUsuarioEmail(Email));
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ObterUsuarioLogin/{Login}")]
        public ActionResult<Usuario> ObterUsuarioLogin(string Login)
        {
            try
            {
                return Ok(_usuarioBLL.ObterUsuarioLogin(Login));
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ObterTodosUsuarios")]
        public ActionResult<List<Usuario>> ObterTodosUsuarios()
        {
            try
            {
                return Ok(_usuarioBLL.ObterTodosUsuarios());
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ValidaUsuario/{Login},{Senha}")]
        public ActionResult<Usuario> ValidaUsuario(string Login, string Senha)
        {
            try
            {
                return Ok(_usuarioBLL.ValidaUsuario(Login,Senha));
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }
    }
}