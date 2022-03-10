using AutoMapper;

namespace PublicApi.DTO.v1.Mappers.Base
{
    public class ApiMapper<TLeftObject, TRightObject> : BaseApiMapper<TLeftObject, TRightObject>
        where TRightObject : class?, new()
        where TLeftObject : class?, new()
    {
        public ApiMapper() : base()
        {
            MapperConfigurationExpression.CreateMap<App.Domain.Note, Note>()
                .ReverseMap();
            MapperConfigurationExpression.CreateMap<Note, App.Domain.Note>()
                .ReverseMap();
            MapperConfigurationExpression.CreateMap<NoteCreate, App.Domain.Note>()
                .ReverseMap();
            MapperConfigurationExpression.CreateMap<App.Domain.Note, NoteCreate>()
                .ReverseMap();
            
            Mapper = new Mapper(new MapperConfiguration(MapperConfigurationExpression));
        }
    }
}