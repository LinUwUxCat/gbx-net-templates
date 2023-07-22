using System;
using GBX.NET;
using GBX.NET.LZO;

GBX.NET.Lzo.SetLzo(typeof(GBX.NET.LZO.MiniLZO));

if (args.Length < 1)
{
    Console.WriteLine("No filename given.");
    return;
}
if (File.Exists(args[0]))
{
    Console.WriteLine("Given file does not exist!");
    return;
}

var node = GameBox.ParseNode(args[0]);
if (node is Node type){
    //Replace Node and type with a GBX Class.
}