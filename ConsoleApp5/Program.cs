using ConsoleApp5;

Flash flash = new("Transcend", "Foo", 16, 3);
string str = flash.GetInfo();
Console.WriteLine(str);
flash.Write(4.8);
Console.WriteLine(flash.GetInfo());
flash.Write(12);
Console.WriteLine(flash.GetInfo());