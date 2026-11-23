using Aplicaciones_Parqueadero.implementaciones;
using Aplicaciones_Parqueadero.interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IConexion, Conexion>();
builder.Services.AddScoped<IClientesAplicacion, ClientesAplicacion>();
builder.Services.AddScoped<IAdministradorAplicacion, AdministradorAplicacion>();
builder.Services.AddScoped<IBoletosAplicacion, BoletosAplicacion>();
builder.Services.AddScoped<ICierreCajaAplicacion, CierreCajaAplicacion>();
builder.Services.AddScoped<IContratosAplicacion, ContratosAplicacion>();
builder.Services.AddScoped<IEspaciosAplicacion, EspaciosAplicacion>();
builder.Services.AddScoped<IFacturasAplicacion, FacturasAplicacion>();
builder.Services.AddScoped<INivelesAplicacion, NivelesAplicacion>();
builder.Services.AddScoped<IPagosAplicacion, PagosAplicacion>();
builder.Services.AddScoped<IPenalizacionesAplicacion, PenalizacionesAplicacion>();
builder.Services.AddScoped<IPlanesAplicacion, PlanesAplicacion>();
builder.Services.AddScoped<IPromocionesAplicacion, PromocionesAplicacion>();
builder.Services.AddScoped<IRegistroSalidasAplicacion, RegistroSalidasAplicacion>();
builder.Services.AddScoped<IRolesAplicacion, RolesAplicacion>();
builder.Services.AddScoped<ITipoVehiculoAplicacion, TipoVehiculoAplicacion>();
builder.Services.AddScoped<ITrabajadoresAplicacion, TrabajadoresAplicacion>();
builder.Services.AddScoped<ITurnosAplicacion, TurnosAplicacion>();
builder.Services.AddScoped<IVehiculosAplicacion, VehiculosAplicacion>();
builder.Services.AddScoped<IZonasAplicacion, ZonasAplicacion>();
builder.Services.AddScoped<ITipo_TrabajadoresAplicacion, Tipo_TrabajadoresAplicacion>();
builder.Services.AddScoped<ITarifasAplicacion, TarifasAplicacion>();
builder.Services.AddScoped<IPermisosAplicacion, PermisosAplicacion>();
builder.Services.AddScoped<IUsuariosAplicacion, UsuariosAplicacion>();
builder.Services.AddScoped<IAuditoriasAplicacion, AuditoriasAplicacion>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "");
app.Run();