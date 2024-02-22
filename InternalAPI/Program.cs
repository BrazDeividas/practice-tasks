using InternalAPI.DbContext;
using InternalAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RecipeDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:InternalServer"]);
});

builder.Services.AddMemoryCache();

builder.Services.AddScoped(typeof(ICacheService<>), typeof(MemoryCacheService<>));
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOutputCache(options =>
{
    options.AddBasePolicy(builder => builder.Expire(TimeSpan.FromSeconds(60)));
    options.AddBasePolicy(builder => builder.Cache());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseOutputCache();

app.Run();
