using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Infrastructure
{
    public static class DatabaseInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<DatabaseOptions>(x =>
            {
                var configuration = x.GetService<IConfiguration>();
                var options = new DatabaseOptions();

                configuration.GetSection("Mongo").Bind(options);
                return options;
            });

            services.AddSingleton<IMongoClient>(x =>
            {
                var configuration = x.GetService<IConfiguration>();
                var options = x.GetService<DatabaseOptions>();

                return new MongoClient(options.ConnectionString);
            });

            return services;
        }

        public static IServiceCollection AddMongo(this IServiceCollection services)
        {
            services.AddSingleton<DatabaseOptions>(x =>
            {
                var configuration = x.GetService<IConfiguration>();
                var options = new DatabaseOptions();
                configuration.GetSection("Mongo").Bind(options);
                return options;
            });

            services.AddSingleton<IMongoClient>(x =>
            {
                var configuration = x.GetService<IConfiguration>();
                var options = x.GetService<DatabaseOptions>();
                return new MongoClient(options.ConnectionString);
            });

            services.AddTransient(x =>
            {
                BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;
                var options = x.GetService<DatabaseOptions>();
                var mongoClient = x.GetService<IMongoClient>();
                var db = mongoClient.GetDatabase(options.Database);
                return db;
            });

            return services;
        }
    }
}
