using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace back_piviii.DAL.Model
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdUsuario { get; set; }

        [BsonElement("Nome")]
        public string Nome { get; set; }

        [BsonElement("Login")]
        public string Login { get; set; }

        [BsonElement("Senha")]
        public string Senha { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("PerfilSuper")]
        public bool PerfilSuper { get; set; }
    }
}