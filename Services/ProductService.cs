using ProductApi.DTOs;
using ProductApi.Models;

public class ProductService : IProductService
{
    private readonly IProductRepository _repo;

    public ProductService(IProductRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Product>> GetAll() => await _repo.GetAll();

    public async Task<Product> GetById(int id) => await _repo.GetById(id);

    public async Task<Product> Add(ProductDto dto)
    {
        var product = new Product
        {
            Name = dto.Name,
            Price = dto.Price
        };

        return await _repo.Add(product);
    }

    public async Task<Product> Update(int id, ProductDto dto)
    {
        var product = await _repo.GetById(id);
        product.Name = dto.Name;
        product.Price = dto.Price;

        return await _repo.Update(product);
    }

    public async Task<bool> Delete(int id) => await _repo.Delete(id);
}