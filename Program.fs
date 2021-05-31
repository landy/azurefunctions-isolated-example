module functest.Program

open System.Threading.Tasks
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.Hosting
open Microsoft.Azure.Functions.Worker.Configuration


//
//    public class Program
//    {
//        public static void Main()
//        {
//            var host = new HostBuilder()
//                .ConfigureFunctionsWorkerDefaults()
//                .Build();
//
//            host.Run();
//        }
//    }
//}

let host =
    HostBuilder()
        .ConfigureFunctionsWorkerDefaults()
        .Build()

host.Run()
