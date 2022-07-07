// See https://aka.ms/new-console-template for more information

using Collections;

Console.WriteLine("Hello, World!");

Collection names = new Collection();
names.Add("David");
names.Add("Bernica");
names.Add("Raymond");
names.Add("Clayton");
foreach (Object name in names)
    Console.WriteLine(name);
Console.WriteLine("Number of names: " + names.
Count());
names.Remove("Raymond");
Console.WriteLine("Number of names: " + names.
Count());
names.Clear();
Console.WriteLine("Number of names: " + names.
Count());
