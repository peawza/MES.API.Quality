using Utils;

var builder = WebApplication.CreateBuilder(args);


/* 
 --- DB Conneted Config---
 
 
 */



/* --- Add Repository & Service ---*/


/* ---Add message bus Or message broker --- */


/* ---Add gRPC --- */


StartupAPIMicoService.StartupCreateBuilder(builder);

var app = builder.Build();


StartupAPIMicoService.StartupCreateApplication(builder, app);
app.Run();





