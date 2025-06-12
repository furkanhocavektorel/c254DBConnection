namespace MvcGiris
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();

            // þu url'e gidince bu metot calissin
            app.MapControllerRoute(
            name: "/test123",
            pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
