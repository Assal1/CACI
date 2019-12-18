using CACI_Lib.Converters;
using CACI_Lib.Interfaces;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace CACI_BinaryStringToIntConvertorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary string:");
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConvertor, BinaryToIntConvertor>()
                .BuildServiceProvider();
                        
            var processConversions = serviceProvider.GetService<IConvertor>();

            //Call the actual service 
            Console.WriteLine(processConversions.Convert(Console.ReadLine()));
            Console.WriteLine("Press enter key to exit!");
            Console.ReadLine();
        }


    }
}
