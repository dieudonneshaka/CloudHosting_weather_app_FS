var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("hello/", HelloMethod);

app.Run();

string HelloMethod()
{
    var helloFolder = new DirectoryInfo(Directory.GetCurrentDirectory());
    var helloPath = Path.Combine(helloFolder.FullName, "hello.txt");




    var file = new FileInfo("hello.txt");
    var filePath = file.FullName;
    Console.WriteLine($"Reading hello from: {filePath}");





    var message = File.ReadAllText("hello.txt"); 

    return "Read from FILE:\n\n" + message;
}


//az webapp up --name dieu-webapi -g test1 --location westeurope --sku B1 --os-type linux