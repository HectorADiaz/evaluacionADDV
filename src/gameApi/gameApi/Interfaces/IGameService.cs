using gameApi.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace gameApi.Interfaces
{
    public interface IGameService
    {
        Task<bool> InitGame();

        Task<GameDto> EndGame();
    }
}
