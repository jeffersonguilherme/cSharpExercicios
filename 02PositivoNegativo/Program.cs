namespace PositivoNegativo {
    class Program{
        static void Main(string[] args){
            Console.Write("Informe um número: ");
            double numero = double.Parse(Console.ReadLine());

            if(numero == 0){
                Console.WriteLine($"O numero informado é igual a zero");
            }else if(numero > 0){
                Console.WriteLine($"o numero {numero} é positivo");
            }else{
                Console.WriteLine($"O número {numero} é negativo");
            }
        }
    }
}