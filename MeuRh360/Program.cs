using Business.Commands;
using Business.Commands.Interfcaes;
using Business.Querys;
using Business.Querys.Interfaces;
using Domain;
using Domain.General;
using Repository;
using Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

//var services = new ServiceCollection();

builder.Services.Configure<AppSettings>(options => configuration.Bind(options));

builder.Services.AddMvc();

builder.Services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IRCompany, RCompany>();
builder.Services.AddTransient<IRUser, RUser>();
builder.Services.AddTransient<IBCompanyCommand, BCompanyCommand>();
builder.Services.AddTransient<IBUserCommand, BUserCommand>();
builder.Services.AddTransient<IBCompanyQuery, BCompanyQuery>();
builder.Services.AddTransient<IBCompanyQuery, BCompanyQuery>();
builder.Services.AddTransient<IBUserQuery, BUserQuery>();

builder.Services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
//services.AddMvc();
//services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



//app.UseAuthentication();
//app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});

app.Run();
