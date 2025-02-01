namespace DiaDaSemana {
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Semana");
            Console.WriteLine("Domingo - 1");
            Console.WriteLine("Segunda - 2");
            Console.WriteLine("Terça - 3");
            Console.WriteLine("Quarta - 4");
            Console.WriteLine("Quinta - 5");
            Console.WriteLine("Sexta - 6");
            Console.WriteLine("Sábado - 7");
            Console.Write("Informe seu o dia: ");
            int diaSemana = int.Parse(Console.ReadLine());

            switch(diaSemana){
                case 1: 
                Console.WriteLine("Domingo");
                break;
                case 2: 
                Console.WriteLine("Segunda");
                break;
                case 3: 
                Console.WriteLine("Terça");
                break;
                case 4: 
                Console.WriteLine("Quarta");
                break;
                case 5: 
                Console.WriteLine("Quinta");
                break;
                case 6: 
                Console.WriteLine("Sexta");
                break;
                case 7: 
                Console.WriteLine("Sábado");
                break;
                default:
                Console.WriteLine("Informe um dia valido");
                break;
            }
        }
    }
}