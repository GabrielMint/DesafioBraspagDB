using FluentValidation;
using System.Collections.Generic;

namespace DesafioDatabase{
    public class TransactionValidation : AbstractValidator<Transaction>{
        public TransactionValidation(){
                       
            RuleFor(tr => tr.Acquirer).NotNull().WithMessage("Adquirente é obrigatório")
            .Must(BeAValidAcquirer).WithMessage("Informe um adquirente válido (A, B, C) ");

            RuleFor(tr => tr.Type).NotNull()
            .WithMessage("Tipo de transação é obrigatória")
            .Must(BeAValidType).WithMessage("Informe um tipo de transação válida (credito, debito)");

            RuleFor(tr => tr.Brand).NotNull()
            .WithMessage("Bandeira é obrigatória")
            .Must(BeAValidBrand).WithMessage("Informe uma bandeira válida (visa, master)");
            
            RuleFor(tr => tr.Value).NotNull().WithMessage("Valor é obrigatório");

            RuleFor(tr => tr.Value).GreaterThan(1).WithMessage("Valor deve ser maior que 1")
            .LessThan(double.MaxValue);
            
        }

        private bool BeAValidAcquirer(char Acquirer){
            List<char> validValues = new List<char>(){'A', 'B', 'C'};

            return validValues.Contains(Acquirer);

        }

        private bool BeAValidType(string Type){
            List<string> validValues = new List<string>(){"credito", "debito"};

            return validValues.Contains(Type);

        }

        private bool BeAValidBrand(string Brand){
            List<string> validValues = new List<string>(){"visa", "master"};

            return validValues.Contains(Brand);

        }
        
    }
}