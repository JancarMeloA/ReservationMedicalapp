using Microsoft.EntityFrameworkCore;
using MedicalReservationsApp.Server.DdContext;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ReservationContext>(Configuration => Configuration.UseLazyLoadingProxies().UseSqlServer("Name=DefaultConnection"));

//cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:5173", "https://localhost:7200/").AllowAnyHeader().AllowAnyMethod();
                      });
});


var app = builder.Build();
 
app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}





app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.UseCors(MyAllowSpecificOrigins);
app.MapControllers();
app.MapFallbackToFile("/index.html");

app.Run();
