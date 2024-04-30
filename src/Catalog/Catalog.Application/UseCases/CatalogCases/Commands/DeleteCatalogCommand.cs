using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.CatalogCases.Commands
{
    public class DeleteCatalogCommand : IRequest<ResponseModel>
    {
        public Guid CatalogId { get; set; }
    }
}
