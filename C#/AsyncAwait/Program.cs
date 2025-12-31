using System;
using System.Threading.Tasks;
using AsyncAwait;

TiendaOnline tienda = new TiendaOnline();

await ProcesarPedidoExitoso();

async Task ProcesarPedidoExitoso()
{
    Console.WriteLine("Caso: Pedido (async/await secuencial)'\n");

    Pedido pedido = new Pedido(
        "Laptop",
        2,
        "190-412-421-12",
        1200,
        "Av. Riva Agüero"
        );

    try
    {
        await tienda.ConsultarStockAsync(pedido.Producto);
        pedido.CodigoTransaccion = await tienda.ProcesarPagoAsync(pedido.Tarjeta, pedido.PrecioTotal);
        pedido.NumeroSeguimiento = await tienda.EnviarPedidoAsync(pedido.Direccion);
        await tienda.ActualizarInventarioAsync(pedido.Producto, pedido.Cantidad);
        
        pedido.Completado = true;
        Console.WriteLine($"\n{pedido}");
        Console.WriteLine($"Código: {pedido.CodigoTransaccion} | Tracking {pedido.NumeroSeguimiento}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}