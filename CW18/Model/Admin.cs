using System.ComponentModel;

namespace CW18.Model;

public class Admin
{
    public int Id { get; set; }

    [DisplayName("نام")]
    public string FisrtName { get; set; }

    [DisplayName("نام خانودادگی")]
    public string LastName { get; set; }

    [DisplayName("رمز وررود")]
    public string Password { get; set; }

    [DisplayName("ایمیل")]
    public string Email { get; set; }
    public bool IsAdmin { get; set; }
}
