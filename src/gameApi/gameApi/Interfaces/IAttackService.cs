using gameApi.DTOs;

namespace gameApi.Interfaces
{
    public interface IAttackService
    {
        Task<AttackDto> executeAttack();
    }
}
