
namespace GXpert.Membership;

public class SignUpRequest : ServiceRequest
{
    public string DisplayName { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PrnNo { get; set; }
    public string Recaptcha { get; set; }
    public string ExternalProviderToken { get; set; }
}