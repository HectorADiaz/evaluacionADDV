using gameApi.DTOs;
using Microsoft.EntityFrameworkCore; 

namespace gameApi.Services
{
    public class ManticoraService
    {
        public static async Task<ManticoraDto> StatusManticora(ApplicationDbContext context)
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

        public static async Task<int> GetPosition(ApplicationDbContext context)
        {
            // Obtenemos el primer Registro
            var manticoraPosition = await context.manticoras.FirstOrDefaultAsync();
            var number = new ManticoraDto
            {
                manticoraPosition = manticoraPosition.manticoraPosition
            };
            
            //Generamos el Numero Random verificando que no sea igual a la posicion anterior
            Random random = new Random();
            int numeroAleatorio = 0;
            do
            {
                numeroAleatorio = random.Next(1, 6) * 10;
            } while (numeroAleatorio < 10 || numeroAleatorio > 50 || number.manticoraPosition == numeroAleatorio);

            //Guardamos la informacion en la bd
            manticoraPosition.manticoraPosition = numeroAleatorio;
            await context.SaveChangesAsync();
            return numeroAleatorio;

         
        }
    }
}
