using MySpace.Application;
using MySpace.Infrastructure;
using MySpace.Api;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
    .AddPresentation()
    .AddApplication()    
    .AddInfrastructure(builder.Configuration);     
}

var app = builder.Build();
{   
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

