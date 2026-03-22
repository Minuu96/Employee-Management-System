using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure static file serving for wwwroot
builder.Services.AddEndpointsApiExplorer();

// Add CORS to allow JS fetch from same server
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("AllowAll");
app.UseStaticFiles(); // Serve HTML/CSS/JS

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

// Default route to serve index.html
app.MapFallbackToFile("index.html");

app.Run();
