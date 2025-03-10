using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(o => o.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

// Register services (stubs)
builder.Services.AddSingleton<ILlmService, OpenAiLlmService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.MapControllers();
app.Run();

public interface ILlmService
{
    Task<string> CompleteAsync(string prompt);
}

public class OpenAiLlmService : ILlmService
{
    public Task<string> CompleteAsync(string prompt)
    {
        // Stub - replace with real OpenAI / Azure OpenAI call
        return Task.FromResult($"[AI Response to: {prompt.Substring(0, Math.Min(50, prompt.Length))}...]");
    }
}
