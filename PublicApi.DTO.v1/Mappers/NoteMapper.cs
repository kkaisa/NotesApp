using PublicApi.DTO.v1.Mappers.Base;

namespace PublicApi.DTO.v1.Mappers;

public class NoteMapper: ApiMapper<App.Domain.Note, Note>
{
    public Note MapNote(App.Domain.Note inObject)
    {
        var note = Mapper.Map<Note>(inObject);
      
        return note;
    }

}