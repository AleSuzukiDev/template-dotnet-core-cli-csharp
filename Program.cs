using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração que exibe alguma informação no console
            Console.WriteLine("Hello World!"); 
            
            //Guardar uma informação e utilizar depois
            //variavel
            //para declarar uma variavel no C#, precisamos de duas coisas:
            //1ª coisa que precisamos: tipo da informação
            //2ª coisa que precisamos: nome da variável. Esse nome não pode ter espaços, caracteres especiais ou começar com número

            //Meu nome é Alessandra Suzuki
            string nome;
            
            //Aqui atribuo o conteúdo a string
            nome = "Alessandra Suzuki";

            //pode ser assim também. Desta forma eu declaro e ja atribuo
            string nome2 = "Alessandra Suzuki Mariano";

            Console.WriteLine(nome);
            
            Console.WriteLine(nome2);
        }
    }
}
