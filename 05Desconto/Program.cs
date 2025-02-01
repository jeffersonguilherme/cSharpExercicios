namespace Desconto {
    class Program {
        static void Main(string[] args){
            Console.Write("Valor da compra: R$ ");
            float valorDaCompra = float.Parse(Console.ReadLine());

            if(valorDaCompra >= 100){
                float valorPagar =  valorDaCompra - (valorDaCompra*0.1f);
                Console.WriteLine($"Valor da compra é de R$ {valorDaCompra}, com o desconto de 10% fica R$ {valorPagar}");
            }else{
                Console.WriteLine($"Valor da compra é de R$ {valorDaCompra}");
            }
        }
    }
}