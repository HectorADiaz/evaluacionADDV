using gameApi.DTOs;
using Microsoft.EntityFrameworkCore; 

namespace gameApi.Services
{
    public class ManticoraService
    {
        public static async Task<ManticoraDto> CrearManticoraDtoAsincronamente(ApplicationDbContext context)
        {
            //obtenemos el primer registro
             var firstManticora = await context.manticoras.FirstOrDefaultAsync();

            if (firstManticora != null)
            {
                // Si se encontró un registro, asigna sus valores a un objeto ManticoraDto
                var manticoraDto = new ManticoraDto
                {
                    manticoraId = firstManticora.manticoraId,
                    manticoraPoints = firstManticora.manticoraPoints,
                    manticoraPosition = firstManticora.manticoraPosition
                };

                return manticoraDto;
            }
            else
            {
                 return new ManticoraDto();
            }
        }
    }
}
