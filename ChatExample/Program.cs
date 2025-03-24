using ChatExample.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.MapHub<ChatHub>("/Chat");

app.Run();
