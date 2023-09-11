namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if (string.IsNullOrWhiteSpace(date) || date.Length != 10)
        {
            // Fecha está en blanco o no tiene el formato esperado (dd/mm/yyyy).
            return "Invalid date";
        }

        string[] parts = date.Split('/');
        if (parts.Length != 3)
        {
            // Fecha no se puede dividir en tres partes (día, mes, año).
            return "Invalid date";
        }

        if (!int.TryParse(parts[0], out int day) || !int.TryParse(parts[1], out int month) || !int.TryParse(parts[2], out int year))
        {
            // No se pueden convertir los componentes a números enteros.
            return "Invalid date";
        }

        if (day < 1 || day > 31 || month < 1 || month > 12)
        {
            // Valores de día o mes están fuera de rango.
            return "Invalid date";
        }
        return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
    }
}
