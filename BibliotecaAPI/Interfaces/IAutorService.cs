using BibliotecaAPI.DTOs;

namespace BibliotecaAPI.Interfaces;

public interface IAutorService
{
    Task<List<AutorDto>> ObtenerTodosAsync();

    Task<AutorDto?> ObtenerPorIdAsync(int id);

    Task CrearAsync(AutorCreateDto autor);

    Task<bool> ActualizarAsync(int id, AutorUpdateDto autor);

    Task<bool> EliminarAsync(int id);

    Task<List<AutorDto>> ObtenerPorNacionalidadAsync(string pais);

    Task<List<AuthorizationEndpointConventionBuilderExtensions>> ObtenerSinLibrosAsync();

    Task<AutorDto?> ObtenerAutorConMasLibrosAsync();
}