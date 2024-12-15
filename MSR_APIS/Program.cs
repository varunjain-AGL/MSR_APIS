using MSR_APIS.Helper;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//builder.Services.AddControllers().AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.PropertyNamingPolicy = null;
//    options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.Never;
//});
builder.Services.AddScoped<ApiHelper>();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();


