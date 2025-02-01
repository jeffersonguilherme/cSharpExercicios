namespace UsuarioValidacao {
    class Program{
        static void Main(string[] args){
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa {NomeUsuario = "jeff", Senha="123"});
            pessoas.Add(new Pessoa {NomeUsuario = "Jenneffer", Senha="1234"});
            pessoas.Add(new Pessoa {NomeUsuario = "genesis", Senha="123"});

            string nomeUserInfor = Console.ReadLine();

            Console.WriteLine(pessoas.Count);
            for(var i = 0; i < pessoas.Count; i++ ){
                if(pessoas[i].NomeUsuario == nomeUserInfor){
                    
                    Console.Write("Informe a senha: ");
                    string senhaInformada = Console.ReadLine();

                    if(senhaInformada == pessoas[i].Senha){
                        Console.WriteLine("Senha corretar");
                    }else{
                        Console.WriteLine("Senha incorrera");
                    }
                }
            }

        }
    }

    public class Pessoa{
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
    }
}