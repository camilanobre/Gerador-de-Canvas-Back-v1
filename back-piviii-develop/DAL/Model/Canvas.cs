using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace back_piviii.DAL.Model
{
    public class Canvas
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdCanvas { get; set; }

        [BsonElement("NomeProjeto")]
        public string NomeProjeto { get; set; }

        [BsonElement("DataCriacaoProjeto")]
        public DateTime DataCriacaoProjeto { get; set; }

        [BsonElement("IdUsuario")]
        public string IdUsuario { get; set; }

        [BsonElement("CompartilharCanvas")]
        public bool CompartilharCanvas { get; set; }


        [BsonElement("ParceirosChave")]
        public string ParceirosChave { get; set; }

        [BsonElement("AtividadesChave")]
        public string AtividadesChave { get; set; }

        [BsonElement("RecursosChave")]
        public string RecursosChave { get; set; }

        [BsonElement("PropostaValor")]
        public string PropostaValor { get; set; }

        [BsonElement("RelacoesClientes")]
        public string RelacoesClientes { get; set; }

        [BsonElement("CanaisVenda")]
        public string CanaisVenda{ get; set; }

        [BsonElement("SegmentosMercado")]
        public string SegmentosMercado { get; set; }

        [BsonElement("EstruturaCustos")]
        public string EstruturaCustos { get; set; }

        [BsonElement("FontesRenda")]
        public string FontesRenda { get; set; }

        [BsonElement("Autor")]
        public string Autor { get; set; }
    }
}
