using RevenueAPI;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISqlAccess, SqlAccess>();
builder.Services.AddSingleton<IServices, Services>();

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


