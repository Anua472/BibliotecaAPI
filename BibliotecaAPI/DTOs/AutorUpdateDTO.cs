namespace BibliotecaAPI.DTOs;

public class AutorUpdateDto
{
    public string Nombre { get; set; } = string.Empty;

    public string Nacionalidad { get; set; } = string.Empty;

    public DateTime? FechaNacimiento  { get; set; }
}