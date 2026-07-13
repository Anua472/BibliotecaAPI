namespace BibliotecaAPI.DTOs;

public class LibroCreateDto
{
    public string Titulo { get; set; } = string.Empty;

    public string Genero { get; set; } = string.Empty;

    public int? NumeroPaginas { get; set; }

    public decimal? Precio { get; set; }

    public required bool Disponible { get; set; }

    public DateTime? FechaPublicacion { get; set; }

    public required int AutorId { get; set; }

    public static implicit operator LibroCreateDto?(LibroDto? v)
    {
        throw new NotImplementedException();
    }
}