using CoreLayer.IntRepository;
using CoreLayer.IntService;
using CoreLayer.IntUnitOfWork;
using DataAccessLayer;
using DataAccessLayer.Repository;
using DataAccessLayer.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Service;

var builder = WebApplication.CreateBuilder(args);







// Add services to the container.

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IWorkService, WorkService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();






builder.Services.AddDbContext<FeleketDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConStr").ToString(), sqlServerOptionsAction: sqloptions =>
    {
        sqloptions.EnableRetryOnFailure();

        sqloptions.MigrationsAssembly("DataAccessLayer");
    });
    options.EnableSensitiveDataLogging();
});


var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        builderer =>
        {
            builderer.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            

        });
});


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


app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();