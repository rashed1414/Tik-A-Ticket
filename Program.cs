global using Tik_A_Ticket.DTO;

global using Tik_A_Ticket.Models;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Tik_A_Ticket.Data;
using Tik_A_Ticket.Repositories.AuthRepository;
using Tik_A_Ticket.Services.ChampionShipServices;
using Tik_A_Ticket.Services.FanServices;
using Tik_A_Ticket.Services.MatchServices;
using Tik_A_Ticket.Services.PlayerServices;
using Tik_A_Ticket.Services.PricingCategoryServices;
using Tik_A_Ticket.Services.StadiumServices;
using Tik_A_Ticket.Services.TeamServices;
using Tik_A_Ticket.Services.TicketServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Tik' ATicket EndPoints", Version = "v1" });
    c.AddSecurityDefinition("oauth2",new OpenApiSecurityScheme{
        Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    c.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IFanServices, FanServices>();
builder.Services.AddScoped<ITicketServices, TicketServices>();
builder.Services.AddScoped<IChampionShipServices, ChampionShipServices>();
builder.Services.AddScoped<IMatchServices, MatchServices>();
builder.Services.AddScoped<IPlayerServices, PlayerServices>();
builder.Services.AddScoped<IPricingCategoryServices, PricingCategoryServices>();
builder.Services.AddScoped<IStadiumServices, StadiumServices>();
builder.Services.AddScoped<ITeamServices, TeamServices>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
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
