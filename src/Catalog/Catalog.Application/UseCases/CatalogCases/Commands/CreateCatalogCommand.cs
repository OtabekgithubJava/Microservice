using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.CatalogCases.Commands;

public class CreateCatalogCommand : IRequest<ResponseModel> 
{
    public string Name { get; set; }
    public string Description { get; set; }
}