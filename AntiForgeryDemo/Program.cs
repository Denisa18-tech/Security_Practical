var builder = WebApplication.CreateBuilder(args);

// Add MVC services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// HTTPS Redirection
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

// Authorization Middleware
app.UseAuthorization();

// Default Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Register}/{id?}"
);

app.Run();