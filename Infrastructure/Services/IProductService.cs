using Domain;
using Domain.Reponce;

namespace Infrasructure.Services;

public interface IProductService
{
    Task<Response<string>> GetProductAsync(Product product, int summa, string phone, Diapazon diapazon);
}