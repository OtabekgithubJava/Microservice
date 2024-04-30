using MediatR;

namespace Catalog.Application.UseCases.CatalogCases.Queries;

public class GetAllCatalogsQuery : IRequest<List<Domain.Catalog>>
{
}