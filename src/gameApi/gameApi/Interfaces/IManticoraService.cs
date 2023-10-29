using gameApi.DTOs;

namespace gameApi.Interfaces
{
    public interface IManticoraService
    {
        Task<ManticoraDto> StatusManticora();

        Task<int> GetPosition();


    }
}
