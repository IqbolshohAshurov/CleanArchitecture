using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Application.Features.Languages.Queries.GetDetailQuery;

public class LanguageViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}