using AdventureWorksPersistence.DataAccess;
using AdventureWorksPersistence.Entities.Product;
using AdventureWorksPersistence.Models;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Batch;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
                .AddFluentValidation(opts => opts.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()))
                .AddOData(options =>
                {
                    options.Select().Expand().Filter().OrderBy().SetMaxTop(null).Count();
                    options.AddRouteComponents("api", GetEdmModel());
                });


builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = false;
    options.ReportApiVersions = true;
    options.ApiVersionReader = new HeaderApiVersionReader("x-api-version");
});

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddTransient<IAdventureWorksDataAccess, AdventureWorksDataAccess>();

builder.Services.AddDbContext<AdventureWorksDBContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("AdventureWorksDBConnection"));
    opts.EnableSensitiveDataLogging();
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    var apiversiondescriptionprovider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        foreach(var description in apiversiondescriptionprovider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "AdventureWorksApi v1");
        }
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


static IEdmModel GetEdmModel()
{
    ODataConventionModelBuilder builder = new();
    builder.EntitySet<ProductDto>("ProductDto");
    return builder.GetEdmModel();
}
