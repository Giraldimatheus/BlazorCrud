global using BlazorCRUD.Client.Services.EmpresasServices;
global using BlazorCRUD.Shared;
using BlazorCRUD.Client;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

builder.Services.AddScoped<IEmpresasServices, EmpresasServices>();


await builder.Build().RunAsync();
