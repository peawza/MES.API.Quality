using Utils;

var builder = WebApplication.CreateBuilder(args);

StartupAPIMicoService.StartupCreateBuilder(builder);

var app = builder.Build();


StartupAPIMicoService.StartupCreateApplication(builder, app);
app.Run();





