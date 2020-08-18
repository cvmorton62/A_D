namespace A_D.Domain.Models
{
    public class DeviceNfieldVersion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Device Device { get; set; }
    }
}
