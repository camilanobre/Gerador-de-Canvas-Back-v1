using System.Collections.Generic;
using back_piviii.DAL.DTO;
using back_piviii.Extensions.Responses;

namespace back_piviii.DAL.DAO
{
    public interface ICanvasDAO
    {
        List<CanvasDTO> ObterTodosCanvas();
        List<CanvasDTO> ObterTodosCanvasPublicos();
        List<CanvasDTO> ObterTodosCanvasPrivados();
        CanvasDTO ObterCanvasPorId(string IdCanvas);
        List<CanvasDTO> ObterTodosCanvasUsuario(string IdUsuario);

        void AdicionarCanvas(CanvasDTO canvasDTO);
        void AtualizarCanvas(string IdCanvas,CanvasDTO canvasDTO);
        void DeletarCanvas(string IdCanvas);
    }
}