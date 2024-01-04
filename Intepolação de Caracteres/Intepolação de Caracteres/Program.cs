﻿string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
string message2 = $"{updateText} {version}";
Console.WriteLine(message2);
Console.WriteLine($"{updateText} {version}");

string projectName = "First-Project";
Console.WriteLine($@"C:\output\{projectName}\Data");

string projectName2 = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"View English output:
    c:\Exercise\{projectName2}\data.txt");

Console.WriteLine($@"{russianMessage}:
    c:\Exercise\{projectName2}\ru-RU\data.txt");

/*string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
*/