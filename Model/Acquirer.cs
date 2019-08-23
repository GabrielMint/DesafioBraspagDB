using System.Collections.Generic;

namespace DesafioDatabase{

    public class Acquirer{
        
        public int Id { get; set; }
        public char Type { get; set; }
        public List<Tax> Taxes { get; set; }
    }
}