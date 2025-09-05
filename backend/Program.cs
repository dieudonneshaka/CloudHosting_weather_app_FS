Console.WriteLine(@$"Current Directory:

{Directory.GetCurrentDirectory()}");


Console.WriteLine(@$"Executing Assembly:

{Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}");


string path = Directory.GetCurrentDirectory();

Console.WriteLine("The current directory is {0}", path);


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
    // Look for all asset in the same forlder, where the program (dill's etc.)
    // (usually bin/debug/net9.0 net)

    //var helloFolder = new DirectoryInfo(Directory.GetCurrentDirectory());
    //var helloPath = Path.Combine(helloFolder.FullName, "hello.txt");

    var assemblyFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
    var filepath = Path.Combine(assemblyFolder ?? "", "hello.txt");
    
    

// print to console absolute path (fullname)

    // var file = new FileInfo("hello.txt");
    // filePath = file.FullName;
    Console.WriteLine($"Reading hello from: {filepath}");

    if (!File.Exists(filepath))
    {
        // File nnot found
        return "File not found: " + filepath;
    }
    // File was found ok print debug info to console absolute path (fullname)
    // file was found ok print debug 

    Console.WriteLine($"File found: {filepath}");
    var message = File.ReadAllText(filepath); 

    return "Read from FILE:\n\n" + message;
}


//az webapp up --name dieu-webapi -g test1 --location westeurope --sku B1 --os-type linux
