using AuthAccess.AuthService;
using RevenueAPI;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<DataAccess.SqlAccess.ISqlAccess, DataAccess.SqlAccess.SqlAccess>();
builder.Services.AddSingleton<IServices, Services>();

builder.Services.AddSingleton<AuthAccess.SqlAccess.ISqlAccess, AuthAccess.SqlAccess.SqlAccess>();
builder.Services.AddSingleton<IAuthServices, AuthServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.ApiConfig();
app.UseHttpsRedirection();



app.Run();


