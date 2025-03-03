﻿var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

var app = builder.Build();

app.UseMvc(routes => routes.MapRoute("Default", "{controller=Patient}/{action=Index}"));

app.UseFileServer();

app.Run();

