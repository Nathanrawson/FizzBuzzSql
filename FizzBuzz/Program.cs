using FizzBuzz;
using FizzBuzz.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection()
    .AddSingleton<IFizzBuzzService, FizzBuzzService>()
    .AddSingleton<IFizzBuzzData>(provider => new FizzBuzzData("YourConnectionString"))
    .AddSingleton<FizzBuzzProcessor>()
    .BuildServiceProvider();

var fizzBuzzProcessor = services.GetService<FizzBuzzProcessor>();
fizzBuzzProcessor!.Process();