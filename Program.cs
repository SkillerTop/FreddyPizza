var builder = WebApplication.CreateBuilder(args);

// ������� ������ �� ����������.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ���������� �������� ������� HTTP-������.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // �������� �� ������������� HSTS - 30 ���. �������, ��� ���������� ������ �� ��� ������������ �������, ���. https://aka.ms/aspnetcore-hsts.
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
