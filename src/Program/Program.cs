﻿namespace TestDateFormat;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    /// <summary>
    /// Punto de entrada al programa principal.
    /// </summary>
    public static void Main()
    {
        string testDate = "12/10/1997";
        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
    }
}