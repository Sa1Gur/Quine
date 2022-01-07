var str = @"var str = @""

Console.WriteLine(str[..12] + str[..12] + str[11] + str[12..] + str[11] + str[^1] + str[12..]);";

Console.WriteLine(str[..12] + str[..12] + str[11] + str[12..] + str[11] + str[^1] + str[12..]);
