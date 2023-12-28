using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QueryTool.Data;
using QueryTool.Services.DataCreators;
using QueryTool.Services.DataProviders;
using QueryTool.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace QueryTool
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private IHost host;
    public App()
    {
      host = Host.CreateDefaultBuilder()
        .ConfigureServices((hostContext, services) =>
        {
          string dbConnectionString = hostContext.Configuration.GetConnectionString("Default")?? String.Empty;
          services.AddDbContext<CourseContext>(options => options.UseSqlite(dbConnectionString));
          services.AddSingleton<ICourseCreator, CourseCreator>();
          // services.AddSingleton<IFacultyCreator, IFacultyCreator>();
          services.AddSingleton<ICourseProvider, CourseProvider>();
          // services.AddSingleton<IFacultyProvider, IFacultyProvider>();
          services.AddSingleton<MainViewModel, MainViewModel>();
          services.AddSingleton(s => new MainWindow()
          {
            DataContext = s.GetRequiredService<MainViewModel>()
          });
        })
        .Build();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
      host.Start();

      // Initalize Database and update
      using (CourseContext context = host.Services.GetRequiredService<CourseContext>())
      {
        context.Database.Migrate();
      }

      MainWindow = host.Services.GetRequiredService<MainWindow>();

      MainWindow.Show();

      base.OnStartup(e);
    }

    protected override void OnExit(ExitEventArgs e)
    {
      host.Dispose();
      base.OnExit(e);
    }
  }

}
