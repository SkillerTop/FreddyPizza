var builder = WebApplication.CreateBuilder(args);

// Додайте сервіси до контейнера.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Налаштуйте конвейер обробки HTTP-запитів.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Значення за замовчуванням HSTS - 30 днів. Можливо, вам захочеться змінити це для продукційних сценаріїв, див. https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "order",
        pattern: "{controller=Order}/{action=Register}/{id?}");
});

app.Run();
