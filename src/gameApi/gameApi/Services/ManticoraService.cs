using gameApi.DTOs;
using gameApi.Interfaces;
using Microsoft.EntityFrameworkCore; 

namespace gameApi.Services
{
    public class ManticoraService: IManticoraService
    {
        private readonly ApplicationDbContext _context;
        public ManticoraService( ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ManticoraDto> StatusManticora()
        {
            //obtenemos el primer registro
             var firstManticora = await _context.manticoras.FirstOrDefaultAsync();

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

        public async Task<int> GetPosition()
        {
            // Obtenemos el primer Registro
            var manticoraPosition = await _context.manticoras.FirstOrDefaultAsync();
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
            await _context.SaveChangesAsync();
            return numeroAleatorio;

         
        }
    }
}
