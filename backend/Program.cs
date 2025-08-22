var builder = WebApplication.CreateBuilder(args);
// 2
// We may need to configure builder before building (as an exaxample add controllers etc.)
// 3
var app = builder.Build();

//4
// MAP. ENDEPOINT <-> metodi()
app.MapGet("/", () => "Hello World!"); // using "anomonomous functions"
app.MapGet("hello/", HelloMethod);

// After run .... program will stop here and wait for GET/POSTS/UPDATE calls ..

app.Run();

// ---------------------------
Console.WriteLine("this shouls never happen... (is impossible, should be at least)");
// we will never get here

// what about those

string HelloMethod()
{
    var helloFolder = new DirectoryInfo(Directory.GetCurrentDirectory());
    var helloPath = Path.Combine(helloFolder.FullName, "hello.txt");

// print to console absolute path (fullname)

    var file = new FileInfo("hello.txt");
    var filePath = file.FullName;
    Console.WriteLine($"Reading hello from: {filePath}");


    var message = File.ReadAllText("hello.txt"); 

    return "Read from FILE:\n\n" + message;
}


//az webapp up --name dieu-webapi -g test1 --location westeurope --sku B1 --os-type linux