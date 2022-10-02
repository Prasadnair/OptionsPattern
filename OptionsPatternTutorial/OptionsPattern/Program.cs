using OptionsPattern.Monitor;
using OptionsPattern.Monitor.Implementation;
using OptionsPattern.Options;
using OptionsPattern.SnapShot;
using OptionsPattern.SnapShot.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services
    .Configure<OptionsTutorial>(builder.Configuration.GetSection(OptionsTutorial.Position));

builder.Services
    .Configure<SnapShot>(builder.Configuration.GetSection(SnapShot.Position));

builder.Services
    .Configure<MonitorOption>(builder.Configuration.GetSection(MonitorOption.Position));

builder.Services.AddScoped<ISnapShotCheckWithScope, SnapShotCheckWithScope>();

/// UnComment this line and see whether the code executed or not. 
/// you will get a runtime error 
//builder.Services.AddSingleton<ISnapShotCheckWithSingleton, SnapShotCheckWithSingleton>();


builder.Services.AddScoped<IOptionsMonitorCheck, OptionMonitorCheck>();

//Uncomment each of the below one at a time and see how this behaves
//builder.Services.AddSingleton<IOptionsMonitorCheck, OptionMonitorCheck>();

//builder.Services.AddTransient<IOptionsMonitorCheck, OptionMonitorCheck>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
