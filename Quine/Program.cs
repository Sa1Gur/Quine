var _2blQuotePos = 38;

var str = @$"var {nameof(_2blQuotePos)} = {_2blQuotePos};

var str = @$""

Console.WriteLine(
    str[..(_2blQuotePos + 1)] +
    str[..4] + str[^2] + str[^8..^2] + str[60] + str[4..16] + str[^10] + str[^1] +
    str[(_2blQuotePos - 5)..(_2blQuotePos - 2)] + 
    str[^2] + str[4..16] + str[^1] + 
    str[21..(_2blQuotePos + 1)] +
    str[_2blQuotePos..^8] +
    str[^8..^1] + str[^2] + str[^1] + str[^1] +
    str[_2blQuotePos] +
    str[^9] +
    str[(_2blQuotePos + 1)..^8]
    );nameof{{}}";

Console.WriteLine(
    str[..(_2blQuotePos + 1)] +
    str[..4] + str[^2] + str[^8..^2] + str[60] + str[4..16] + str[^10] + str[^1] +
    str[(_2blQuotePos - 5)..(_2blQuotePos - 2)] + 
    str[^2] + str[4..16] + str[^1] + 
    str[21..(_2blQuotePos + 1)] +
    str[_2blQuotePos..^8] +
    str[^8..^1] + str[^2] + str[^1] + str[^1] +
    str[_2blQuotePos] +
    str[^9] +
    str[(_2blQuotePos + 1)..^8]
    );
