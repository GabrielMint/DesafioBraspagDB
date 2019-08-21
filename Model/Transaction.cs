using System.ComponentModel.DataAnnotations;

namespace DesafioDatabase{
    public class Transaction{

        public int Id { get; set; }

        [AcquirerValidValues(ErrorMessage = "Adquirente Inválido! Valores permitidos: A, B, C")]
        [Required(ErrorMessage = "O Adquirente é obrigatório", AllowEmptyStrings = false)]
        public char Acquirer { get; set; }

        [Range(1, double.MaxValue)]
        [Required(ErrorMessage = "O Valor é obrigatório", AllowEmptyStrings = false)]
        public double Value { get; set; }

        [TransactionTypeValidValues(ErrorMessage = "Tipo de transação inválida! Valores permitidos: Credito, Debito")]
        [Required(ErrorMessage = "O Tipo da transação é obrigatório", AllowEmptyStrings = false)]
        public string Type { get; set; }

        [BrandValidValues(ErrorMessage = "Bandeira inválida! Valores permitidos: visa, master")]
        [Required(ErrorMessage = "A bandeira é obrigatório", AllowEmptyStrings = false)]
        public string Brand { get; set; }

    }
}