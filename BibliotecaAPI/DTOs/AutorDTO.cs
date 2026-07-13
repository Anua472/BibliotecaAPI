namespace BibliotecaAPI.DTOs;

public class AutorDto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string Nacionalidad { get; set; } = string.Empty;

    public DateTime FechaNacimiento { get; set; }

    public List<LibroResumenDto> Libros { get; set; } = [];
}