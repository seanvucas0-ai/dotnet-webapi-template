var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
// Controllers
builder.Services.AddControllers();

// Health Checks
builder.Services.AddHealthChecks();

// Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseExceptionHandler("/error");

// Swagger UI
app.UseSwagger();
app.UseSwaggerUI();

// Controllers
app.MapControllers();

// Health Endpoint
app.MapHealthChecks("/health");

app.Run();
