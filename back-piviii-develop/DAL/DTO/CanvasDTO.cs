using System;

namespace back_piviii.DAL.DTO
{
    public class CanvasDTO
    {
        public string IdCanvas { get; set; }
        public string NomeProjeto { get; set; }
        public DateTime DataCriacaoProjeto { get; set; }
        public string IdUsuario { get; set; }
        public bool CompartilharCanvas { get; set; }

        public string ParceirosChave { get; set; }
        public string AtividadesChave { get; set; }
        public string RecursosChave { get; set; }
        public string PropostaValor { get; set; }
        public string RelacoesClientes { get; set; }
        public string CanaisVenda{ get; set; }
        public string SegmentosMercado { get; set; }
        public string EstruturaCustos { get; set; }
        public string FontesRenda { get; set; }
        public string Autor { get; set; }
    }
}