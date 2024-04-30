using Catalog.Domain.Entities;
using Catalog.Domain.Entities.DTOS;
using MediatR;

namespace Catalog.Application.UseCases.CatalogCases.Commands;

public class UpdateCatalogCommand : ProductCatalogDTO, IRequest<ResponseModel>
{
    public Guid CatalogId { get; set; }
}