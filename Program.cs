using Microsoft.EntityFrameworkCore;
using SSQ_RBillCoreAPIWeb.Models;

var builder = WebApplication.CreateBuilder(args);


// ✅ CORS Setup
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        policy =>
        {
            policy
                .WithOrigins("https://localhost:7198", "http://localhost:5167") // your allowed URLs
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

// ?? Add DbContext
builder.Services.AddDbContext<RBillWebDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RBillWebDB")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ CORS use
app.UseCors("AllowLocalhost");

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI(options =>
//    {
//        options.SwaggerEndpoint("/swagger/v1/swagger.json", "SSQ_RBillCoreAPIWeb v1");
//        options.RoutePrefix = string.Empty; // 👈 ye line add karo
//    });
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
