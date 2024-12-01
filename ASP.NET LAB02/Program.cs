var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

app.MapControllerRoute(name: "cars_shortcut",
                pattern: "moto",
                defaults: new { controller = "Car", action = "List" });
app.Run();
=======
app.Run();
>>>>>>> c3c395388fea5d2473f0bb6f6bc1e4af2a454227
=======
app.Run();
>>>>>>> c3c395388fea5d2473f0bb6f6bc1e4af2a454227
=======
app.Run();
>>>>>>> c3c395388fea5d2473f0bb6f6bc1e4af2a454227
