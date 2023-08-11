using Application.Implements;
using Application.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Mappers;
using Persistence.Repository.Implements;
using Persistence.Repository.Interfaces;
using Persistence.Security;

namespace TriviaApi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();

			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();

			services.AddDbContext<ApplicationDbContext>(options =>
			options.UseSqlServer(Configuration.GetConnectionString("Connection")));
			
			services.AddAutoMapper(
					typeof(CategoryMapperProfile),
					typeof(QuestionMapperProfile),
					typeof(AnswerMapperProfile)
				);

			services.AddAuthentication("BasicAuthentication")
				.AddScheme<AuthenticationSchemeOptions, BasicAuthHandler>("BasicAuthentication", null);
			

			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IQuestionRepository, QuestionRepository>();
			services.AddScoped<IQuestionService, QuestionService>();
			services.AddScoped<IAnswerRepository, AnswerRepository>();
			services.AddScoped<IAnswerService, AnswerService>();
			services.AddScoped<IUserService, UserService>();

			services.AddCors(options=>
			{
				options.AddPolicy("NuevaPolitica", app =>
				{
					app.AllowAnyOrigin()
					.AllowAnyHeader() 
					.AllowAnyMethod();
				});
			});

		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				
			}
			app.UseSwagger();
			app.UseSwaggerUI();
			app.UseHttpsRedirection();
			app.UseAuthentication();

			app.UseRouting();

			app.UseCors("NuevaPolitica");

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
