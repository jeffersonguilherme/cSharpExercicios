namespace NotaEscolar {
    class Program {
        static void Main(string[] args){
            Console.Write("Informe a nota do aluno: ");
            double notaAluno = double.Parse(Console.ReadLine());

            if(notaAluno < 60 ){
                Console.WriteLine($"O aluno tirou {notaAluno}, ele estar REPROVADO");
            }else if(notaAluno >= 60 & notaAluno <= 89 ){
                Console.WriteLine($"O aluno tirou {notaAluno}, ele estar APROVADO");

            }else if(notaAluno >= 90){
                Console.WriteLine($"O aluno tirou {notaAluno}, EXCELENTE");

            }
        }
    }
}