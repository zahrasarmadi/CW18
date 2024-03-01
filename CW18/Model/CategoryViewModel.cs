using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CW18.Model;

public class CategoryViewModel
{
    [DisplayName("نام دسته بندی")]
    public string Name { get; set; }
}
