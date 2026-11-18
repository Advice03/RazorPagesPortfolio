using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesPortfolio.Pages;

public class ProjectsModel : PageModel
{
    public List<ProjectInfo> Projects { get; private set; } = new();

    public void OnGet()
    {
        Projects = new List<ProjectInfo>
        {
            new("Task Manager", "Create, update, complete and filter tasks. Add due dates and priority levels.", "Beginner", "Razor Pages", "C#", "Validation", "LINQ", "✓"),
            new("Student Portal", "Build student profiles, course enrolment and a results overview with role-based access.", "Intermediate", "Razor Pages", "SQL Server", "EF Core", "Identity", "▣"),
            new("Expense Tracker", "Record income and expenses, group transactions by category and show monthly summaries.", "Intermediate", "Razor Pages", "C#", "EF Core", "Charts", "R"),
            new("Help Desk System", "Allow users to submit support tickets and administrators to assign and update ticket status.", "Advanced", "Razor Pages", "Identity", "SQL Server", "Authorization", "✉"),
            new("Inventory Manager", "Track products, stock levels, suppliers and low-stock alerts.", "Intermediate", "Razor Pages", "C#", "EF Core", "CRUD", "▤"),
            new("Appointment Booking", "Create appointment requests, manage availability and prevent overlapping bookings.", "Advanced", "Razor Pages", "C#", "SQL Server", "Validation", "◷")
        };
    }

    public record ProjectInfo(string Name, string Description, string Level, string Tech1, string Tech2, string Tech3, string Tech4, string Symbol)
    {
        public string[] Technologies => new[] { Tech1, Tech2, Tech3, Tech4 };
    }
}
