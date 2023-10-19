namespace gameApi.DTOs
{
    public class GameDto
    {
        public int gameId {  get; set; }
        public int cityPoints { get; set; }
        public ManticoraDto manticora { get; set; }
    }
}
