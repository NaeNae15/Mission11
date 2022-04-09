using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookstoreProject.Pages
{
    [Authorize(Roles = "Admins")]
    public class AdminPageModel : PageModel
    {
    }
}
