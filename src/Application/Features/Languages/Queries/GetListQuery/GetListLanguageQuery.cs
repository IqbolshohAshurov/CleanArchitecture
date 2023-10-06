using MediatR;

namespace Application.Features.Languages.Queries.GetListQuery;

public class GetListLanguageQuery: IRequest<IEnumerable<LanguageVm>> { }