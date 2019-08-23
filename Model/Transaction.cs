using System.ComponentModel.DataAnnotations;

namespace DesafioDatabase{
    public class Transaction{

        public int Id { get; set; }

        public char Acquirer { get; set; }

        public double Value { get; set; }

        public string Type { get; set; }

        public string Brand { get; set; }

    }
}