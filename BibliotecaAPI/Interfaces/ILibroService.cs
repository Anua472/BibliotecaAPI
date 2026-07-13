using BibliotecaAPI.DTOs;

namespace BibliotecaAPI.Interfaces;

public interface ILibroService
{
    Task<List<LibroDto>> ObtenerTodosAsync();

    Task<LibroDto?> ObtenerPorIdAsync(int id);

    Task CrearAsync(LibroCreateDto libro);

    Task<bool> ActualizarAsync(int id, LibroUpdateDto libro);

    Task<bool> EliminarAsync(int id);

    Task<List<LibroDto>> ObtenerPorGeneroAsync(string genero);

    Task<List<LibroDto>> ObtenerPorAutorAsync(int autorId);

    Task<List<LibroDto>> ObtenerDisponiblesAsync();

    Task<List<LibroDto>> ObtenerNoDisponiblesAsync();

    Task<List<LibroDto>> ObtenerBaratosAsync();

    Task<List<LibroDto>> ObtenerCarosAsync();

    Task<List<LibroDto>> ObtenerPorRangoPrecioAsync(decimal min, decimal max);

    Task<List<LibroDto>> ObtenerPorNumeroPaginasAsync(int min, int max);

    Task<List<LibroDto>> ObtenerRecientesAsync();

    Task<List<LibroDto>> BuscarPorTituloAsync(string texto);

    Task<EstadisticasDto> ObtenerEstadisticasAsync();

    Task<LibroDto?> ObtenerMasCaroAsync();

    Task<LibroDto?> ObtenerMasBaratoAsync();

    Task<bool> PrestarAsync(int id);

    Task<bool> DevolverAsync(int id);
}