using ChatApp.Components;
using Microsoft.SemanticKernel;

#pragma warning disable SKEXP0001, SKEXP0010

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services
    .AddKernel()
    .AddAzureOpenAIChatClient(
        "gpt-4.1-mini",
        builder.Configuration["AzureOpenAI:Endpoint"] ??
        throw new InvalidOperationException("Missing configuration: AzureOpenAi:Endpoint. See the README for details."),
        builder.Configuration["AzureOpenAI:Key"] ??
        throw new InvalidOperationException("Missing configuration: AzureOpenAi:Key. See the README for details."));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();
app.UseStaticFiles();
app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();
