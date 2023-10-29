using gameApi.DTOs;
using gameApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace gameApi.Services
{
    public class AttackService: IAttackService
    {
        private readonly ApplicationDbContext _context;
        public AttackService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AttackDto> executeAttack()
        {            
            AttackDto Articles = new AttackDto();
            await Task.Delay(300000);

            return Articles;
        }


    }
}
