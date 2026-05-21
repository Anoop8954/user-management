using Microsoft.AspNetCore.Mvc;
using ProductApi.DTOs;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAll());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
        => Ok(await _service.GetById(id));

    [HttpPost]
    public async Task<IActionResult> Post(ProductDto dto)
        => Ok(await _service.Add(dto));

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, ProductDto dto)
        => Ok(await _service.Update(id, dto));

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
        => Ok(await _service.Delete(id));
}