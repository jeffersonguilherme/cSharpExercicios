namespace PedraPapelTesoura {
    class Program{
        static void Main(string[] args){
            Random random = new Random();
            int escolhaMaquina = random.Next(1, 4);
            Console.WriteLine(escolhaMaquina);
            Console.WriteLine("Informe um numero de 1 a 3");
            Console.WriteLine("sendo 1: Pedra");
            Console.WriteLine("sendo 2: Papel");
            Console.WriteLine("sendo 3: Tesoura");
            int escolhaUsuario = int.Parse(Console.ReadLine());

                switch(escolhaUsuario){
                        case 1:
                            Console.WriteLine("Pedra");
                        break;
                        case 2: 
                            Console.WriteLine("Papel");
                        break;
                        case 3: 
                            Console.WriteLine("Tesoura");
                        break;
                        default: 
                            Console.WriteLine("Informe um valor valido");
                        break;
                } 

                if((escolhaUsuario == 1 && escolhaMaquina == 3)|| (escolhaUsuario == 2 && escolhaMaquina == 1)||(escolhaUsuario == 2 && escolhaMaquina == 1)){
                    Console.WriteLine("Você venceu!");
                }else if(escolhaMaquina == escolhaUsuario){
                    Console.WriteLine("Empate");
                }else{
                    Console.WriteLine("O computador venceu!");
                }
            }    
        }
    }