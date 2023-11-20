using MiriDvoritiEvents;
using Microsoft.EntityFrameworkCore;
using Events.model;
using Event.BL.Interface;
using Event.BL;
using Event.DAL.Interface;
using Event.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EventContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("PeopleConnectionString"));
}
 );


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEventLogic, EventLogic>();
builder.Services.AddScoped<IEventRepository, EventRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
