using FastCode.WebFresher072023.BL.Service.Foods;
using FastCode.WebFresher072023.DL.Repository.Foods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Thực hiện cấu hình viết PascalCase khi dữ liệu trả về từ Json
builder.Services.AddControllers().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Tiêm phụ thuộc của AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

/*
 - Mỗi lần thực hiện một IEmployeeRepository thì tương ứng sẽ có lớp thể hiện của các phương thức đó
 - Khi mà mình có gọi những cái Repository này ở các tầng nào khác (Controller, BL, DL) thì đều chỉ khởi tạo 1 instant
 */
builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IFoodService, FoodService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(builder => builder
    .WithOrigins("http://127.0.0.1:5173")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.UseMiddleware<ExceptionMiddleware>();

app.Run();
