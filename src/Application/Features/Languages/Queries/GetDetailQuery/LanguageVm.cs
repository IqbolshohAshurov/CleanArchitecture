using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Application.Features.Languages.Queries.GetDetailQuery;

public class LanguageVm
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}