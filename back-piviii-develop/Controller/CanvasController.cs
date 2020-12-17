using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using back_piviii.BLL;
using back_piviii.DAL.DTO;
using back_piviii.Utils;
using back_piviii.BLL.Exceptions;
using Newtonsoft.Json;
using System.Threading.Tasks;
using back_piviii.DAL.Model;
using back_piviii.Extensions.Responses;
using AutoMapper;

namespace back_piviii.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CanvasController : ControllerBase
    {
        private readonly ICanvasBLL _canvasBLL;
        private ILoggerManager _logger;
        private IMapper _mapper;

        public CanvasController(ICanvasBLL canvasBLL, ILoggerManager logger, IMapper mapper)
        {
            _canvasBLL = canvasBLL;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost("AdicionarCanvas")]
        public ActionResult<Canvas> AdicionarCanvas(CanvasDTO canvasDTO)
        {
            try
            {
                _canvasBLL.AdicionarCanvas(_mapper.Map<CanvasDTO>(canvasDTO));
                return Ok(new ApiResponse(200, "sucesso."));
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        [HttpPut("AtualizarCanvas/{IdCanvas}")]
        public ActionResult<Canvas> AtualizarCanvas(string IdCanvas, CanvasDTO canvasDTO)
        {
            try
            {
                _canvasBLL.AtualizarCanvas(IdCanvas, _mapper.Map<CanvasDTO>(canvasDTO));
                return Ok(new ApiResponse(200, $"Canvas {IdCanvas} atualizado com sucesso."));
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpDelete("DeletarCanvas/{IdCanvas}")]
        public ActionResult<Canvas> DeletarCanvas(string IdCanvas)
        {
            try
            {
                _canvasBLL.DeletarCanvas(IdCanvas);
                return Ok(new ApiResponse(200, $"Canvas {IdCanvas} deletado."));
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ObterCanvasPorId/{IdCanvas}")]
        public ActionResult<Canvas> ObterCanvasPorId(string IdCanvas)
        {
            try
            {
                return Ok(_canvasBLL.ObterCanvasPorId(IdCanvas));
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ObterTodosCanvas")]
        public ActionResult<List<Canvas>> ObterTodosCanvas()
        {
            try
            {
                return Ok(_canvasBLL.ObterTodosCanvas());
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ObterTodosCanvasPublicos")]
        public ActionResult<List<Canvas>> ObterTodosCanvasPublicos()
        {
            try
            {
                return Ok(_canvasBLL.ObterTodosCanvasPublicos());
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ObterTodosCanvasPrivados")]
        public ActionResult<List<Canvas>> ObterTodosCanvasPrivados()
        {
            try
            {
                return Ok(_canvasBLL.ObterTodosCanvasPrivados());
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }

        [HttpGet("ObterTodosCanvasUsuario/{IdUsuario}")]
        public ActionResult<List<Canvas>> ObterTodosCanvasUsuario(string IdUsuario)
        {
            try
            {
                return Ok(_canvasBLL.ObterTodosCanvasUsuario(IdUsuario));
            }
            catch (System.Exception ex)
            {
                
                throw new SystemException(ex.Message);
            }
        }
    }
}