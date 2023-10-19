namespace gameApi.DTOs
{
    public class AttackDto
    {
        public int attackId {  get; set; }
        public GameDto game { get; set; }
        public DefenderDto defender { get; set; }
    }
}
