using TODO.Api.Configurations;
using TODO.Api.Middleware;
using TODO.Application;
using TODO.Application.Common;
using TODO.Domain.Interfaces;
using TODO.Infrastructure;
using TODO.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.AddInfrastructure(builder.Configuration)
    .AddApplication()
    .AddScoped(typeof(IRepository<>), typeof(EfRepository<>))
    .AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
    

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new ApiMapperProfile());
    config.AddProfile(new ApplicationMapperProfile());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var scopedProvider = scope.ServiceProvider;
    try
    {
        var todoContext = scopedProvider.GetRequiredService<TodoContext>();
        await TodoContextSeed.SeedAsync(todoContext, app.Logger);
    }
    catch (Exception ex)
    {
        app.Logger.LogError(ex, "An error occurred seeding the DB.");
    }
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCustomExceptionHandler();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
