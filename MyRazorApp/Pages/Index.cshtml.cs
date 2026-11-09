// File: Pages/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;

public class IndexModel : PageModel
{
    public string Message { get; set; } = string.Empty;
    public List<string> FeaturedStaff { get; set; } = [];

    public void OnGet()
    {
        Message = "Welcome to ASP.NET Core Razor Pages";
        FeaturedStaff = ["Alice Johnson", "Brian Lee", "Carla Gomez"];
    }
}
