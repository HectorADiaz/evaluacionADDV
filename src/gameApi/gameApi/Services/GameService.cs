using gameApi.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace gameApi.Services
{
    public class GameService
    {
        public static async Task<GameDto> InitGame(ApplicationDbContext context)
        {
            var statusGame = await context.games
                .Include(s => s.Manticora)
                .FirstOrDefaultAsync();
            var statusDefender = await context.defenders.ToListAsync();



            var _statusDefender = new DefenderDto
            {
                balance = 15,
                shot = 5
            };

            foreach (var defender in statusDefender)
            {
                defender.balance = _statusDefender.balance;
                defender.shot = _statusDefender.shot;
            }

            statusGame.cityPoints = 100;
            statusGame.Manticora.manticoraPoints = 10;

            await context.SaveChangesAsync();


            var response = new GameDto();

            return response;
        }

        public static async Task<GameDto> EndGame(ApplicationDbContext context)
        {
            var response = new GameDto();

            return response;
        }
    }
}
