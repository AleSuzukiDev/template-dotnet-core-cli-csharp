using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração que exibe alguma informação no console
            //Console.WriteLine("Hello World!"); 
            
            //Guardar uma informação e utilizar depois
            //variavel
            //para declarar uma variavel no C#, precisamos de duas coisas:
            //1ª coisa que precisamos: tipo da informação
            //2ª coisa que precisamos: nome da variável. Esse nome não pode ter espaços, caracteres especiais ou começar com número

            
            #region DeclarandoNomes
            /*
                //Meu nome é Alessandra Suzuki
                string nome;
                
                //Aqui atribuo o conteúdo a string
                nome = "Alessandra Suzuki";

                //pode ser assim também. Desta forma eu declaro e ja atribuo
                string nome2 = "Alessandra Suzuki Mariano";

                Console.WriteLine(nome);
                Console.WriteLine(nome2);
            */
            #endregion
            

            
            
            #region DeclaracaoPorAssociação
            /*
            //Tipos de variáveis podem ser opcionais se o C# conseguir determina-los por associação.
            var nome = "Ale";
            var sobrenome = "Suzuki";
            */
            #endregion
            

           
            #region ConcatenacaoDeVariaveis
             /*
            //Tipos de variáveis podem ser opcionais se o C# conseguir determina-los por associação.
            var nome = "Ale";
            var sobrenome = "Suzuki";

            //Concatenação (unir informações de forma lógica)
            Console.WriteLine(nome + " " + sobrenome);

            var nomeCompleto = nome + " " + sobrenome; 
            Console.WriteLine(nomeCompleto);
            */
            #endregion


            #region InterpolacaoDeVariaveis
            /*
            var nome = "Alessandra";
            var sobrenome = "Suzuki";
            var nomeCompleto = $"{nome} {sobrenome}";
            Console.WriteLine(nomeCompleto);
            */
            #endregion

            #region PegarInformacao
            
            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}!");
            
            #endregion

        }
    }
}
