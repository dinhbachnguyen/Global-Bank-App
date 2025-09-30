using Microsoft.EntityFrameworkCore;
using Bank.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// EF Core SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=C:/Users/cooic/OneDrive/Bureau/vuejs/bank-project/bank.api/bank.db"));

// CORS for your Vue dev server (adjust port)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173") // change to your front-end origin
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILogger<Program>>();


// Ensure DB created and migrations applied (for dev)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
    logger.LogInformation("Database migration applied successfully.");
}

// Middleware
if (app.Environment.IsDevelopment())
{
    logger.LogInformation("Running in Development mode. Swagger enabled.");
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowFrontend");
logger.LogInformation("CORS policy 'AllowFrontend' applied.");

app.UseHttpsRedirection();
logger.LogInformation("HTTPS redirection enabled.");

app.UseAuthorization();
logger.LogInformation("Authorization middleware enabled.");

app.MapControllers();
logger.LogInformation("Controllers mapped.");

logger.LogInformation("Application starting up...");
app.Run();
