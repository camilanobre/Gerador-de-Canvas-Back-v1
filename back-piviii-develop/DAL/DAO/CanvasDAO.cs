using back_piviii.DAL.Model;
using back_piviii.DAL.DTO;
using System;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace back_piviii.DAL.DAO
{
    public class CanvasDAO : ICanvasDAO
    {
        private readonly IMongoContext _context;

        public CanvasDAO(IMongoContext context)
        {
            _context = context;
        }

        //ADCIONA UM NOVO CANVAS
        public void AdicionarCanvas(CanvasDTO canvasDTO)
        {
            Canvas novoCanvas = new Canvas
            {
                NomeProjeto = canvasDTO.NomeProjeto,
                DataCriacaoProjeto = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                ParceirosChave = canvasDTO.ParceirosChave,
                AtividadesChave = canvasDTO.AtividadesChave,
                RecursosChave = canvasDTO.RecursosChave,
                PropostaValor = canvasDTO.PropostaValor,
                RelacoesClientes = canvasDTO.RelacoesClientes,
                CanaisVenda = canvasDTO.CanaisVenda,
                SegmentosMercado = canvasDTO.SegmentosMercado,
                EstruturaCustos = canvasDTO.EstruturaCustos,
                FontesRenda = canvasDTO.FontesRenda,
                Autor = canvasDTO.Autor,

                IdUsuario = canvasDTO.IdUsuario,
                CompartilharCanvas = canvasDTO.CompartilharCanvas
            };
            _context.CollectionCanvas.InsertOne(novoCanvas);
        }

        //ATUALIZA UM CANVAS EXISTENTE
        public void AtualizarCanvas(string IdCanvas, CanvasDTO canvasDTO)
        {
            Canvas canvas = new Canvas
            {
                IdCanvas = IdCanvas,
                NomeProjeto = canvasDTO.NomeProjeto,
                DataCriacaoProjeto = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                ParceirosChave = canvasDTO.ParceirosChave,
                AtividadesChave = canvasDTO.AtividadesChave,
                RecursosChave = canvasDTO.RecursosChave,
                PropostaValor = canvasDTO.PropostaValor,
                RelacoesClientes = canvasDTO.RelacoesClientes,
                CanaisVenda = canvasDTO.CanaisVenda,
                SegmentosMercado = canvasDTO.SegmentosMercado,
                EstruturaCustos = canvasDTO.EstruturaCustos,
                FontesRenda = canvasDTO.FontesRenda,
                Autor = canvasDTO.Autor,

                IdUsuario = canvasDTO.IdUsuario,
                CompartilharCanvas = canvasDTO.CompartilharCanvas
            };
            _context.CollectionCanvas.ReplaceOne(can => can.IdCanvas == IdCanvas, canvas);
        }

        //EXCLUI UM CANVAS
        public void DeletarCanvas(string IdCanvas)
        {
            _context.CollectionCanvas.DeleteOne(can => can.IdCanvas == IdCanvas);
        }

        //OBTEM UM CANVAS POR SEU ID
        public CanvasDTO ObterCanvasPorId(string IdCanvas)
        {
            var canvas = _context.CollectionCanvas.Find<Canvas>(can => can.IdCanvas == IdCanvas).FirstOrDefault();

            CanvasDTO canvasDTO = new CanvasDTO
            {
                IdCanvas = IdCanvas,
                NomeProjeto = canvas.NomeProjeto,
                DataCriacaoProjeto = canvas.DataCriacaoProjeto,
                ParceirosChave = canvas.ParceirosChave,
                AtividadesChave = canvas.AtividadesChave,
                RecursosChave = canvas.RecursosChave,
                PropostaValor = canvas.PropostaValor,
                RelacoesClientes = canvas.RelacoesClientes,
                CanaisVenda = canvas.CanaisVenda,
                SegmentosMercado = canvas.SegmentosMercado,
                EstruturaCustos = canvas.EstruturaCustos,
                FontesRenda = canvas.FontesRenda,
                Autor = canvas.Autor,

                IdUsuario = canvas.IdUsuario,
                CompartilharCanvas = canvas.CompartilharCanvas
            };
            return canvasDTO;
        }

        //OBTEM TODOS OS CANVAS PUBLICOS
        public List<CanvasDTO> ObterTodosCanvasPublicos()
        {
            List<CanvasDTO> canvasDTOs = new List<CanvasDTO>();
            var canvas = _context.CollectionCanvas.Find<Canvas>(can => true).ToList();

            foreach (var item in canvas)
            {
                CanvasDTO canvasDTO = new CanvasDTO
                {
                    IdCanvas = item.IdCanvas,
                    NomeProjeto = item.NomeProjeto,
                    DataCriacaoProjeto = item.DataCriacaoProjeto,
                    ParceirosChave = item.ParceirosChave,
                    AtividadesChave = item.AtividadesChave,
                    RecursosChave = item.RecursosChave,
                    PropostaValor = item.PropostaValor,
                    RelacoesClientes = item.RelacoesClientes,
                    CanaisVenda = item.CanaisVenda,
                    SegmentosMercado = item.SegmentosMercado,
                    EstruturaCustos = item.EstruturaCustos,
                    FontesRenda = item.FontesRenda,
                    Autor = item.Autor,

                    IdUsuario = item.IdUsuario,
                    CompartilharCanvas = item.CompartilharCanvas
                };
                canvasDTOs.Add(canvasDTO);

                if (item.CompartilharCanvas == false)
                { canvasDTOs.Remove(canvasDTO); }    
            }
            return canvasDTOs;
        }

        //OBTEM TODOS OS CANVAS PRIVADOS
        public List<CanvasDTO> ObterTodosCanvasPrivados()
        {
            List<CanvasDTO> canvasDTOs = new List<CanvasDTO>();
            var canvas = _context.CollectionCanvas.Find<Canvas>(can => true).ToList();

            foreach (var item in canvas)
            {
                CanvasDTO canvasDTO = new CanvasDTO
                {
                    IdCanvas = item.IdCanvas,
                    NomeProjeto = item.NomeProjeto,
                    DataCriacaoProjeto = item.DataCriacaoProjeto,
                    ParceirosChave = item.ParceirosChave,
                    AtividadesChave = item.AtividadesChave,
                    RecursosChave = item.RecursosChave,
                    PropostaValor = item.PropostaValor,
                    RelacoesClientes = item.RelacoesClientes,
                    CanaisVenda = item.CanaisVenda,
                    SegmentosMercado = item.SegmentosMercado,
                    EstruturaCustos = item.EstruturaCustos,
                    FontesRenda = item.FontesRenda,
                    Autor = item.Autor,

                    IdUsuario = item.IdUsuario,
                    CompartilharCanvas = item.CompartilharCanvas
                };
                canvasDTOs.Add(canvasDTO);

                if (item.CompartilharCanvas == true)
                { canvasDTOs.Remove(canvasDTO); }    
            }
            return canvasDTOs;
        }

        //OBTEM TODOS OS CANVAS
        public List<CanvasDTO> ObterTodosCanvas()
        {
            List<CanvasDTO> canvasDTOs = new List<CanvasDTO>();
            var canvas = _context.CollectionCanvas.Find<Canvas>(can => true).ToList();

            foreach (var item in canvas)
            {
                CanvasDTO canvasDTO = new CanvasDTO
                {
                    IdCanvas = item.IdCanvas,
                    NomeProjeto = item.NomeProjeto,
                    DataCriacaoProjeto = item.DataCriacaoProjeto,
                    ParceirosChave = item.ParceirosChave,
                    AtividadesChave = item.AtividadesChave,
                    RecursosChave = item.RecursosChave,
                    PropostaValor = item.PropostaValor,
                    RelacoesClientes = item.RelacoesClientes,
                    CanaisVenda = item.CanaisVenda,
                    SegmentosMercado = item.SegmentosMercado,
                    EstruturaCustos = item.EstruturaCustos,
                    FontesRenda = item.FontesRenda,
                    Autor = item.Autor,

                    IdUsuario = item.IdUsuario,
                    CompartilharCanvas = item.CompartilharCanvas
                };
                canvasDTOs.Add(canvasDTO);
            }
            return canvasDTOs;
        }

        //OBTEM TODOS OS CANVAS DO USUARIO
        public List<CanvasDTO> ObterTodosCanvasUsuario(string IdUsuario)
        {
            List<CanvasDTO> canvasDTOs = new List<CanvasDTO>();
            var canvas = _context.CollectionCanvas.Find<Canvas>(can => can.IdUsuario == IdUsuario).ToList();

            foreach (var item in canvas)
            {
                CanvasDTO canvasDTO = new CanvasDTO
                {
                    IdCanvas = item.IdCanvas,
                    NomeProjeto = item.NomeProjeto,
                    DataCriacaoProjeto = item.DataCriacaoProjeto,
                    ParceirosChave = item.ParceirosChave,
                    AtividadesChave = item.AtividadesChave,
                    RecursosChave = item.RecursosChave,
                    PropostaValor = item.PropostaValor,
                    RelacoesClientes = item.RelacoesClientes,
                    CanaisVenda = item.CanaisVenda,
                    SegmentosMercado = item.SegmentosMercado,
                    EstruturaCustos = item.EstruturaCustos,
                    FontesRenda = item.FontesRenda,
                    Autor = item.Autor,

                    IdUsuario = item.IdUsuario,
                    CompartilharCanvas = item.CompartilharCanvas
                };
                canvasDTOs.Add(canvasDTO);
            }
            return canvasDTOs;
        }

    }
}