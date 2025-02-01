namespace MaiorNumero {
    class Program{
        static void Main(string[] args){
            Console.Write("Informe um número: ");
            double primeiroNumero = double.Parse(Console.ReadLine());
            Console.Write("Informe um segundo número: ");
            double segundoNumero = double.Parse(Console.ReadLine());

            if(primeiroNumero > segundoNumero){
                Console.WriteLine($"O número {primeiroNumero} é maior que o número {segundoNumero}");
            }else if(primeiroNumero < segundoNumero){
                Console.WriteLine($"O número {segundoNumero} é maior que o número {primeiroNumero}");
            }else {
                Console.WriteLine($"Os dois números são iguais {primeiroNumero}");
            }


        }
    }
}