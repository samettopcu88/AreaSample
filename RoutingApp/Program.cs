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

//Conventional Base Routing
//app.MapControllerRoute(
//    name:"Products",
//    pattern:"product-category-{categoryId}-{categoryname}-{pruductId}-{productname}",
//    defaults:new {controller="Product",action="Detail"}
//    );

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");




//Attribute Based Routing
app.MapControllers();
app.Run();
