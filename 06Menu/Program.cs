namespace Menu{
    class Program {
        static void Main(string[] args){
            Console.WriteLine("01 - Criar novo usuario");
            Console.WriteLine("02 - Editar Usuario");
            Console.WriteLine("03 -Excluir usuario");
            double opcaoSelecionada = double.Parse(Console.ReadLine());
            
            switch(opcaoSelecionada){
                case  1:
                Console.WriteLine("Informe o nome do usuario");
                break;
                case  2:
                Console.WriteLine("Qual o usuario deseja editar");
                break;
                case  3: 
                Console.WriteLine("Qual usuario deseja excluir");
                break;
                default:
                Console.WriteLine("Informe uma condição valida");
                break;
            }
        }
    }
}