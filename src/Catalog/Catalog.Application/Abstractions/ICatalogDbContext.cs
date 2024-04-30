using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.Abstractions;

public interface ICatalogDbContext
{
    public DbSet<Domain.Catalog> Catalogs { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}