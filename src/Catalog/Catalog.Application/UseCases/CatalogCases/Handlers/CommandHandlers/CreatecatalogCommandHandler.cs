using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.CatalogCases.Commands;
using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.CatalogCases.Handlers.CommandHandlers;

public class CreatecatalogCommandHandler : IRequestHandler<CreateCatalogCommand, ResponseModel>
{
    private readonly ICatalogDbContext _catalogDb;

    public CreatecatalogCommandHandler(ICatalogDbContext catalogDb)
    {
        _catalogDb = catalogDb;
    }

    public async Task<ResponseModel> Handle(CreateCatalogCommand request, CancellationToken cancellationToken)
    {
        if (request != null)
        {
            var new_catalog = new Domain.Catalog()
            {
                Name = request.Name,
                Description = request.Description
            };
            await _catalogDb.Catalogs.AddAsync(new_catalog, cancellationToken);
            await _catalogDb.SaveChangesAsync(cancellationToken);

            return new ResponseModel()
            {
                StatusCode = 201,
                Message = $"Catalog Is Created | {request.Name}",
                IsSuccess = true
            };
        }

        return new ResponseModel()
        {
            Message = "Perhaps, catalog is null",
            StatusCode = 400
        };
    }
}