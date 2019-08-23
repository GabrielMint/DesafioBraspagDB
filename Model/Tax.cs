using Newtonsoft.Json;

namespace DesafioDatabase{
    public class Tax{
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
        
        [JsonIgnore]
        public Acquirer Acquirer { get; set; }
        public int AcquirerId { get; set; }
    }
}