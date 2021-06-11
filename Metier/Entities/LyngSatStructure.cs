namespace Metier.Entities
{
    public class LyngSatStructure
    {
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string channel;
        public string Channel
        {
            get { return channel; }
            set { channel = value; }
        }

        public LyngSatStructure(string parsedcountry, string parsedchannel)
        {
            country = parsedcountry;
            channel = parsedchannel;
        }
    }
}
