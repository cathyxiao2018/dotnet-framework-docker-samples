﻿using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string message = "Dotnet-bot: Welcome to using .NET Framework!";

        if (args.Length > 0)
        {
            message = String.Join(" ", args);
        }

        Console.WriteLine(GetBot(message));
        Console.WriteLine();
        WriteLine("**Environment**");
        WriteLine($".NET Framework version: {(Environment.Version.Major == 4 ? "4.6.2" : "3.5") } ");
        WriteLine($"OS: {Environment.OSVersion}");
#if DEBUG
            Console.ReadLine();
#endif
    }

    public static string GetBot(string message)
    {
        string bot = $"\n        {message}";
        bot += @"
    __________________
                      \
                       \
                          ....
                          ....'
                           ....
                        ..........
                    .............'..'..
                 ................'..'.....
               .......'..........'..'..'....
              ........'..........'..'..'.....
             .'....'..'..........'..'.......'.
             .'..................'...   ......
             .  ......'.........         .....
             .                           ......
            ..    .            ..        ......
           ....       .                 .......
           ......  .......          ............
            ................  ......................
            ........................'................
           ......................'..'......    .......
        .........................'..'.....       .......
     ........    ..'.............'..'....      ..........
   ..'..'...      ...............'.......      ..........
  ...'......     ...... ..........  ......         .......
 ...........   .......              ........        ......
.......        '...'.'.              '.'.'.'         ....
.......       .....'..               ..'.....
   ..       ..........               ..'........
          ............               ..............
         .............               '..............
        ...........'..              .'.'............
       ...............              .'.'.............
      .............'..               ..'..'...........
      ...............                 .'..............
       .........                        ..............
        .....

";
        return bot;
    }
}