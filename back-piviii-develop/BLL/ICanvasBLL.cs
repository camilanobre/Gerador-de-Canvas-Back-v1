using System.Collections.Generic;
using back_piviii.DAL.DTO;

namespace back_piviii.BLL
{
    public interface ICanvasBLL
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