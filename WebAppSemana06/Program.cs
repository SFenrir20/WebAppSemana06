using WebAppSemana06.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .Add(new ServiceDescriptor(typeof(IProducto),
        new ProductoRepository()));
builder.Services
    .Add(new ServiceDescriptor(typeof(ITemporalVenta),
        new TemporalVentaRepository()));
builder.Services
    .Add(new ServiceDescriptor(typeof(IDistrito),
        new DistritoRepository()));
builder.Services
    .Add(new ServiceDescriptor(typeof(IProveedor),
        new ProveedorRepository()));
builder.Services
    .Add(new ServiceDescriptor(typeof(IOrdenDeCompra),
        new OrdenDeCompraRespository()));
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=OrdenCompras}/{action=VallOrdenCompra}/{id?}");

app.Run();
