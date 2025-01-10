using StoreApp.Infrastructure.Extensions; // Extension kullanıldı

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly); // API-Presentation için
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


// extensionlar burdan gelir
builder.Services.ConfigureDbContext(builder.Configuration); // db
builder.Services.ConfigureIdentity();
builder.Services.ConfigureSession(); // session
builder.Services.ConfigureRepositoryRegistration(); // repolar
builder.Services.ConfigureServiceRegistration(); // serviceler
builder.Services.ConfigureRouting();
builder.Services.ConfigureApplicationCookie();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

app.UseStaticFiles();
app.UseSession();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


// UseEndpoints yerine doğrudan MapAreaControllerRoute ve MapControllerRoute kullanıyoruz
app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.MapRazorPages();
app.MapControllers();

// ESKİ YÖNTEM
// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapAreaControllerRoute(
//         name: "Admin",
//         areaName: "Admin",
//         pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
//     );
//     endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
// });




app.ConfigureAndCheckMigration();
app.ConfigureLocalization();
app.ConfigureDefaultAdminUser();
app.Run();