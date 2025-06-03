

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// REST API => GET, POST, PUT, DELETE

app.MapGet("/", () =>
{
    return "Api is working";
});

app.MapGet("/hello", () =>
{
    return "Get Method: Hello";
});

app.MapPost("/hello", () =>
{
    return "Post Method: Hello";
});

app.MapPut("/hello", () =>
{
    return "Put Method: Hello";
});

app.MapDelete("/hello", () =>
{
    return "Delete Method: Hello";
});

app.Run();