using System.ComponentModel;

namespace CW18.Model;

public class LoginViewModel
{
    [DisplayName("ایمیل")]
    public string Email { get; set; }
    [DisplayName("رمز وررود")]
    public string Password { get; set; }
}
