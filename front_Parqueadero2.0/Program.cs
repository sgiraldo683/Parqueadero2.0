using Aplicacion_Parqueadero.implementaciones;
using Aplicacion_Parqueadero.interfaces;
using Presentacion_Parqueadero.implementaciones;
using Presentaciones_Parqueadero.interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers();
builder.Services.AddScoped<IComunicaciones, Comunicaciones>();
builder.Services.AddScoped<IClientesPresentacion, ClientesPresentacion>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();
app.Run();