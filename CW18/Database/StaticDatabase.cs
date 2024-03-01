using CW18.Model;

namespace CW18.Database;

public static class StaticDatabase
{
    public static Reporter Reporter { get; set; }=new Reporter();
    public static Admin Admin { get; set; }=new Admin();
}