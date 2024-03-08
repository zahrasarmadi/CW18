using CW18.Configuration;
using CW18.Model;

namespace CW18.Ripository;

public class ReporterRepository
{
    Context context = new Context();

    public List<Reporter> GetListReporters()
    {
        var reporters = context.Reporter.ToList();
        return reporters;
    }

    public Reporter GetReporter(int id)
    {
        var reporter = context.Reporter.FirstOrDefault(x => x.Id == id);
        return reporter;
    }

    public void DeleteReporter(int id)
    {
        var reporter = context.Reporter.First(x => x.Id == id);
        context.Reporter.Remove(reporter);
        context.SaveChanges();
    }

    public void UpdateReporter(Reporter model)
    {
        var reporter = context.Reporter.First(x => x.Id == model.Id);

        reporter.FisrtName = model.FisrtName;
        reporter.LastName = model.LastName;
        reporter.Email=model.Email;
        reporter.Password= model.Password;
        context.SaveChanges();
    }
}
