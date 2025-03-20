using HealthApp.Domain;
using HealthApp.Razor.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthApp.Razor.Pages
{
    [Authorize(Roles = "Doctor")]
    public class DoctorModel : PageModel
    {
        public string UserId { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Doctor> Doctors { get; set; }

        public void OnGet()
        {
            UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            Patients = MockData.Patients();
            Doctors = MockData.Doctors();
        }
    }
}