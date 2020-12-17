using AutoMapper;
using back_piviii.DAL.DTO;
using back_piviii.DAL.Model;

namespace back_piviii
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            // Mapeando a classe USUARIO
            CreateMap<UsuarioDTO, Usuario>().
                AfterMap((dto, model) => model.IdUsuario = dto.IdUsuario);
            CreateMap<Usuario, UsuarioDTO>()
                .AfterMap((model, dto) => dto.IdUsuario = model.IdUsuario);

                // Mapeando a classe Frequencia
            CreateMap<CanvasDTO, Canvas>().
                AfterMap((dto, model) => model.IdCanvas = dto.IdCanvas);
            CreateMap<Canvas, CanvasDTO>()
                .AfterMap((model, dto) => dto.IdCanvas = model.IdCanvas);
        }
    }
}
