namespace WebAPI.DTOs.Character
{
    public class UpdateCharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints {get; set;} = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intellegence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}