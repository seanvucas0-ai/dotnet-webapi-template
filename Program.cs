var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Health Checks
builder.Services.AddHealthChecks();

// Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI
app.UseSwagger();
app.UseSwaggerUI();

// Controllers
app.MapControllers();

// Health Endpoint
app.MapHealthChecks("/health");

app.Run();
