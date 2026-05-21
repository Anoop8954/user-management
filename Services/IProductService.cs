using ProductApi.DTOs;
using ProductApi.Models;

public interface IProductService
{
    Task<List<Product>> GetAll();
    Task<Product> GetById(int id);
    Task<Product> Add(ProductDto dto);
    Task<Product> Update(int id, ProductDto dto);
    Task<bool> Delete(int id);
}