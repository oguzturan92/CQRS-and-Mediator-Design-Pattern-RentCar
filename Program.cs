using System.Reflection;
using CQRS_Mediator_Car.CQRSPattern.Handlers.Car;
using CQRS_Mediator_Car.CQRSPattern.Handlers.Feature;
using CQRS_Mediator_Car.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

    builder.Services.AddDbContext<Context>();
    
    // CQRS REGISTRATION İŞLEMLERİ
    builder.Services.AddScoped<GetCarQueryHandler>();
    builder.Services.AddScoped<GetCarFilterQueryHandler>();
    builder.Services.AddScoped<CreateCarCommandHandler>();
    builder.Services.AddScoped<RemoveCarCommandHandler>();
    builder.Services.AddScoped<GetCarByIdQueryHandler>();
    builder.Services.AddScoped<UpdateCarCommandHandler>();

    builder.Services.AddScoped<GetFeatureByCarIdQueryHandler>();
    builder.Services.AddScoped<CreateFeatureCommandHandler>();
    builder.Services.AddScoped<RemoveFeatureCommandHandler>();
    builder.Services.AddScoped<GetFeatureByIdQueryHandler>();
    builder.Services.AddScoped<UpdateFeatureCommandHandler>();

    // MEDIATR REGISTRATION İŞLEMİ
    builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
