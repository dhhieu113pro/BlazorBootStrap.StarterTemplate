using BlazorBootStrap.Client;
using BlazorBootStrap.Host.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddBlazorBootstrap();

// Add HttpClient for server-side rendering
builder.Services.AddHttpClient();
builder.Services.AddScoped<GoogleTrendClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

// API endpoint to proxy Google Trends RSS feed (to bypass CORS)
app.MapGet("/api/google-trends", async (GoogleTrendClient googleTrendClient, string? geo) =>
{
    try
    {
        var country = geo ?? "VN";
        var response = await googleTrendClient.GetTrendsAsync(country);
        return Results.Content(response, "application/xml; charset=utf-8");
    }
    catch (Exception ex)
    {
        return Results.Problem($"Failed to fetch Google Trends: {ex.Message}");
    }
});

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorBootStrap.Client._Imports).Assembly);

app.Run();
