var builder = WebApplication.CreateBuilder(args);

// Add services to the container (you can add services here later, if needed).
builder.Services.AddRazorPages();  // Add Razor Pages support if you want dynamic content

var app = builder.Build();

// Serve static files (like HTML, CSS, JS from wwwroot)
app.UseStaticFiles();

// Map default page route
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
