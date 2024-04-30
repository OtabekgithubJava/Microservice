using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.CatalogCases.Queries;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.UseCases.CatalogCases.Handlers.QueryHandlers;

public class GetAllCatalogsQueryHandler
{
    private readonly ICatalogDbContext _context;
    public GetAllCatalogsQueryHandler(ICatalogDbContext context)
    {
        _context = context;
    }
    public async Task<List<Domain.Catalog>> Handle(GetAllCatalogsQuery request, CancellationToken cancellationToken)
    {
        var catalogs = await _context.Catalogs.ToListAsync();
        return catalogs;
    }
}