namespace MenuOperacoes {
    class Program {
        static void Main(string[] args){
            Console.Write("Informe dois numeros: ");
            string[] valores = Console.ReadLine().Split(" ");
            Console.Write("Informe uma operação:  +, -, *, /");
            string operacao = Console.ReadLine();
            double valor01 = double.Parse(valores[0]);
            double valor02 = double.Parse(valores[1]);
            
            switch(operacao){
                case "+":
                Console.WriteLine($"Soma é {valor01 + valor02}");
                break;
                case "-":
                Console.WriteLine($"A subtração é {valor01 - valor02}");
                break;
                case "*":
                Console.WriteLine($"A multiplicação é {valor01*valor02}");
                break;
                case "/":
                Console.WriteLine($"A divisão é {valor01/valor02}");
                break;
                default:
                Console.WriteLine("Informe um valor valido");
                break;
            }
        }
    }
}