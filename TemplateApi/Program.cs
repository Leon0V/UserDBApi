using TemplateApi.Repositories;
using Microsoft.EntityFrameworkCore;
using Services;
using TemplateApi.Commons.Filters;
using TemplateApi.Services;
using System.Text;
using TemplateApi.Commons;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add<TemplateExceptionFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//setup auth services

builder.Services.AddAuthorization();

var key = Encoding.ASCII.GetBytes(Settings.Secret);
builder.Services.AddAuthentication("Bearer").AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false

    };
});

//adding the database service
builder.Services.AddDbContext<UserContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
}
);
builder.Services.AddScoped<ITokenService, TokenService>();

//builder for dependency injections for the services
builder.Services.AddScoped<IUserService, UserService>();

//builder for the repository
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();


app.MapControllers();

app.Run();
