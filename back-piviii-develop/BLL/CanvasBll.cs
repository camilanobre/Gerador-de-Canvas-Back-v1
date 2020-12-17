using System;
using System.Collections.Generic;
using back_piviii.DAL.DTO;
using back_piviii.DAL.DAO;

namespace back_piviii.BLL
{
    public class CanvasBLL : ICanvasBLL
    {
        public readonly ICanvasDAO _canvasDAO;

        public CanvasBLL(ICanvasDAO canvasDAO)
        {
            _canvasDAO = canvasDAO;
        }

        public void AdicionarCanvas(CanvasDTO canvasDTO)
        {
            try
            {
                _canvasDAO.AdicionarCanvas(canvasDTO);
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public void AtualizarCanvas(string IdCanvas, CanvasDTO canvasDTO)
        {
            bool hasAny = (_canvasDAO.ObterCanvasPorId(IdCanvas)) != null;
            if (!hasAny)
            {
                throw new SystemException("Id do Canvas não Encontrado");
            }

            try
            {
                _canvasDAO.AtualizarCanvas(IdCanvas, canvasDTO);
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public void DeletarCanvas(string IdCanvas)
        {
            bool hasAny = (_canvasDAO.ObterCanvasPorId(IdCanvas)) != null;
            if (!hasAny)
            {
                throw new SystemException("Id do Canvas não Encontrado");
            }

            try
            {
                _canvasDAO.DeletarCanvas(IdCanvas);
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public CanvasDTO ObterCanvasPorId(string IdCanvas)
        {
            try
            {
                var canvas = _canvasDAO.ObterCanvasPorId(IdCanvas);
                return canvas;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public List<CanvasDTO> ObterTodosCanvas()
        {
            try
            {
                var canvas = _canvasDAO.ObterTodosCanvas();
                return canvas;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public List<CanvasDTO> ObterTodosCanvasPublicos()
        {
            try
            {
                var canvas = _canvasDAO.ObterTodosCanvasPublicos();
                return canvas;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public List<CanvasDTO> ObterTodosCanvasPrivados()
        {
            try
            {
                var canvas = _canvasDAO.ObterTodosCanvasPrivados();
                return canvas;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }

        public List<CanvasDTO> ObterTodosCanvasUsuario(string IdUsuario)
        {
            try
            {
                var canvas = _canvasDAO.ObterTodosCanvasUsuario(IdUsuario);
                return canvas;
            }
            catch (System.Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }
    }
}