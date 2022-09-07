namespace authentication
{
    public class registeruser
    {

        public string? username { get; set; }
        public byte[] passwordhash { get; set; }
        public byte[] passwordsalt { get; set; }
    }
}
