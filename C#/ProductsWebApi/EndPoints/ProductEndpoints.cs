using ProductsWebApi.Data;
using ProductsWebApi.DTOs;

namespace ProductsWebApi;

public static class ProductEndpoints
{
    public static void MapProductEndpoint(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/products")
            .WithTags("Products");

        group.MapGet("/", GetAllProducts);
        group.MapGet("/{id:int}", GetProductById);
    }

    private static IResult GetAllProducts(IProductRepository repository)
    {
        var products = repository.GetAll();

        var productsDto = products.Select(p => new ProductDto(
            p.Id,
            p.Name,
            p.Price));
        
        return Results.Ok(productsDto);
    }

    private static IResult GetProductById(int id, IProductRepository repository)
    {
        var product = repository.GetById(id);

        if (product is null)
        {
            return Results.NotFound(new {message = $"Producto con id {id} no encontrado"});
        }
        
        var productDto = new ProductDto(
            product.Id,
            product.Name,
            product.Price
        );
        
        return Results.Ok(productDto);
    }
}
