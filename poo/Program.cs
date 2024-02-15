namespace poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao.menu();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            PicoleDeChocolate picole = new PicoleDeChocolate();
            picole.tamanho(10);
            picole.sabor("Chocolate");
            picole.cor("Marrom");
            picole.confeitos();
            picole.embalagem();
            picole.preco();
            

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            PicoledeMorango picole2 = new PicoledeMorango();
            picole2.tamanho(5);
            picole2.sabor("Morrango");
            picole2.cor("Rosa");
            picole2.confeitos();
            picole2.embalagem();
            picole2.preco();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            PicoledeLimao picole3 = new PicoledeLimao();
            picole3.tamanho(5);
            picole3.sabor("Limao");
            picole3.cor("Branco");
            picole3.confeitos();
            picole3.embalagem();
            picole3.preco();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");


            PicoleCorneto picole4 = new PicoleCorneto();
            picole4.tamanho(5);
            picole4.sabor("Baunilha com Chocolate");
            picole4.cor("Branco, com manchas escuras");
            picole4.confeitos();
            picole4.embalagem();
            picole4.preco();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            Saudacao.selecao();

        }
    }
}
