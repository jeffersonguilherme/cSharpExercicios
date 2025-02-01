namespace Verificando {
    class Program {
        static void Main(string[] args){
            Console.Write("Qual sua data de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());
            int data = DateTime.Now.Year;
            int idade = data - nascimento;

            if((data - nascimento) >= 18){
                Console.WriteLine($"Você tem {idade}");
            }else{
                Console.WriteLine($"Falta {18 - idade} para sua maior idade");
            }
        }
    }
}