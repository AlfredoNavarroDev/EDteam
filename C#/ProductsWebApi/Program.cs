using ProductsWebApi;
using ProductsWebApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*
app.UseHttpsRedirection();
List<Product> products = new List<Product>
{
    new(1, "Laptop Asus Rog Strix G16", 6700.90m),
    new(2, "Mouse Logitech MX Master", 99.90m),
    new(3, "Teclado Mecánico Keychron", 89.90m)
};

app.MapGet("/api/products", () =>
{
    var productsDto = products.Select(p => new ProductDto(
        p.Id,
        p.Name,
        p.Price
    ));
    
    return Results.Ok(productsDto);
});

app.MapPost("/api/products", (CreateProductDto dto) =>
    {
        var newId = products.Any() ? products.Max(p => p.Id) + 1 : 1;
        var product = new Product(newId, dto.Name, dto.Price){CreatedAt = DateTime.UtcNow};

        var productDto = new ProductDto(product.Id, product.Name, product.Price);
        
        products.Add(product);
        
        return Results.Created($"/api/products/{product.Id}", productDto);
    })
    .WithName("CreateProduct")
    .WithTags("Products");

app.MapGet("/api/products", () =>
    {
        return Results.Ok(products);
    })
    .WithName("GetProducts")
    .WithTags("Products");

app.MapGet("/api/products/{id:int}", (int id) =>
    {
        Product product = products.FirstOrDefault(p => p.Id == id);

        if (product is null)
        {
            return Results.NotFound(new { message = "Product not found." });
        }
        return Results.Ok(product);
    })
    .WithName("GetProductById")
    .WithTags("Products");

app.MapPost("/api/products", (Product product) =>
    {
        product.Id = products.Any() ? products.Max(p => p.Id) + 1 : 1;
        products.Add(product);
        return Results.Created($"/api/products/{product.Id}", product);
    })
    .WithName("CreateProduct")
    .WithTags("Products");

app.MapPut("/api/products/{id:int}", (int id, Product UpdatedProduct) =>
    {
        Product product = products.FirstOrDefault(p => p.Id == id);

        if (product is null)
        {
            return Results.NotFound(new { message = "Product not found." });
        }
        
        product.Name = UpdatedProduct.Name;
        product.Price = UpdatedProduct.Price;

        return Results.Ok(product);
    })
    .WithName("UpdateProduct")
    .WithTags("Products");

app.MapDelete("/api/products/{id:int}", (int id) =>
    {
        Product product = products.FirstOrDefault(p => p.Id == id);

        if (product is null)
        {
            return Results.NotFound(new { message = "Product not found." });
        }
        
        products.Remove(product);

        return Results.NoContent();
    })
    .WithName("DeleteProduct")
    .WithTags("Products");
*/


app.MapProductEndpoint();

app.Run();
