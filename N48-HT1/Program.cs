using N48_HT1.Service.Interfaces;
using N48_HT1.Service.Services;

using FileBaseContext.Abstractions.Models.FileContext;
using FileBaseContext.Context.Models.Configurations;
using Microsoft.Extensions.DependencyInjection;
using N48_HT1.DataAccess;

var builder = WebApplication.CreateBuilder(args);

var fileContextOptions = new FileContextOptions<AppFileContext>(Path.Combine(builder.Environment.ContentRootPath, "Data/Storage"));

builder.Services.AddSingleton<IFileContextOptions<IFileContext>>(fileContextOptions);
builder.Services.AddScoped<IDataContext, AppFileContext>(provider =>
{
    var options = provider.GetRequiredService<IFileContextOptions<IFileContext>>();
    var dataContext = new AppFileContext(options);
    dataContext.FetchAsync().AsTask().Wait();

    return dataContext;
});

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

await app.RunAsync();