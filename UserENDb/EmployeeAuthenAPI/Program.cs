using EmployeeAuthenAPI;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSingleton<IAuthenService, AuthenService>();
builder.Services.AddSingleton<ISqlAccess, SqlAccess>();


builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ApiConfiguration();
app.UseHttpsRedirection();

app.Run();


