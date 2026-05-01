using CalendarApp.Entities;
using CalendarApp.Repository;
using CalendarApp.Services;
using CalendarApp.View;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

internal static class Program
{
    public static ServiceProvider ServiceProvider;

    [STAThread]
    static void Main()
    {
        var services = new ServiceCollection();

        ConfigureServices(services);

        ServiceProvider = services.BuildServiceProvider();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(ServiceProvider.GetRequiredService<LoginPage>());
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddTransient<IUserRepo, UserRepo>();
        services.AddTransient<IReminderRepo, ReminderRepo>();
        services.AddTransient<IAppointmentRepo, AppointmentRepo>();
        services.AddTransient<IParticipantRepo, ParticipantRepo>();

        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IReminderService, ReminderService>();
        services.AddTransient<IAppointmentService, AppointmentService>();
        services.AddTransient<IParticipantService, ParticipantService>();

        services.AddTransient<LoginPage>();
        services.AddTransient<RegisterPage>();
        services.AddTransient<CalendarPage>();
        services.AddTransient<ReminderFormPage>();
        services.AddTransient<AppointmentFormPage>();

        services.AddTransient<CalendarContext>();

    }
}
