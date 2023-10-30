using gameApi.DTOs;
using gameApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Microsoft.AspNetCore.Http;
using Serilog;

namespace gameApi.Services
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;
        public GameService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> InitGame()
        {
            bool response = false;
            try 
            { 
                var statusGame = await _context.games
                    .Include(s => s.Manticora)
                    .FirstOrDefaultAsync();
                var statusDefender = await _context.defenders.ToListAsync();
                var _statusDefender = new DefenderDto
                {
                    balance = 100,
                    shot = 5
                };

                foreach (var defender in statusDefender)
                {
                    defender.balance = _statusDefender.balance;
                    defender.shot = _statusDefender.shot;
                }

                statusGame.cityPoints = 15;
                statusGame.Manticora.manticoraPoints = 10;
                await _context.SaveChangesAsync();
                response =  true;

            } catch (Exception ex){
                Log.Error(ex, "Process: " + ex.Message);
            }
            return response;
        }

        public async Task<GameDto> EndGame()
        {
            var response = new GameDto();

            return response;
        }
    }
}
