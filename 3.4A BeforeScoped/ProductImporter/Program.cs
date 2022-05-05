﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductImporter.Shared;
using ProductImporter.Source;
using ProductImporter.Target;
using ProductImporter.Transformation;
using ProductImporter.Transformation.Transformations;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddTransient<Configuration>();

        services.AddTransient<IPriceParser, PriceParser>();
        services.AddTransient<IProductSource, ProductSource>();

        services.AddTransient<IProductFormatter, ProductFormatter>();
        services.AddTransient<IProductTarget, ProductTarget>();

        services.AddTransient<ProductImporter.ProductImporter>();

        services.AddSingleton<IImportStatistics, ImportStatistics>();

        // Do work here
    })
    .Build();

var productImporter = host.Services.GetRequiredService<ProductImporter.ProductImporter>();

productImporter.Run();