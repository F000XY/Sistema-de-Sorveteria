using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    internal abstract class Picole
    {
        public abstract void sabor(string sabor);
        public abstract void cor(string cor);
        public abstract void tamanho(int tamanho);
        public virtual void confeitos()
        {
            Console.WriteLine("o picole não possui confeitos");
        }
        public virtual void embalagem()
        {
            Console.WriteLine("embalagem transparente");
        }

        public virtual void preco() 
        {
           Console.WriteLine("O custo é de 5 reais. ");
           
        }

    }

    class PicoleDeChocolate : Picole
    {
        public override void sabor(string sabor)
        { Console.WriteLine("O sabor do picole é : " +sabor); }
        public override void cor(string cor)
        { Console.WriteLine("A cor do picole é : " +cor); }

        public override void tamanho(int tamanho)
        {  Console.WriteLine("O tamanho do picole em cm é : " +tamanho); }
        public override void preco()
        {
            Console.WriteLine("O custo é de 7 reais. ");

        }

    }

    class PicoledeMorango : Picole
    {
        public PicoledeMorango()
        { Console.WriteLine("Esse sovete vem com pedaços de morango!!!"); }
        public override void sabor(string sabor)
        { Console.WriteLine("O sabor do picole é : " + sabor); }
        public override void cor(string cor)
        { Console.WriteLine("A cor do picole é : " + cor); }

        public override void tamanho(int tamanho)
        { Console.WriteLine("O tamanho do picole em cm é : " + tamanho); }
       
    }

    class PicoledeLimao : Picole
    {
        public PicoledeLimao()
        { Console.WriteLine("Esse sovete é bem azedo viu!!!"); }
        public override void sabor(string sabor)
        { Console.WriteLine("O sabor do picole é : " + sabor); }
        public override void cor(string cor)
        { Console.WriteLine("A cor do picole é : " + cor); }

        public override void tamanho(int tamanho)
        { Console.WriteLine("O tamanho do picole em cm é : " + tamanho); }

    }
    class PicoleCorneto : Picole
    {
        public PicoleCorneto()
        { Console.WriteLine("Esse sovete é em casquinha!!!"); }
        public override void sabor(string sabor)
        { Console.WriteLine("O sabor do picole é : " + sabor); }
        public override void cor(string cor)
        { Console.WriteLine("A cor do picole é : " + cor); }

        public override void tamanho(int tamanho)
        { Console.WriteLine("O tamanho do picole em cm é : " + tamanho); }

        public override void confeitos()
        {
            Console.WriteLine("O sorvete de casquinha possui confeitos");
        }
        public override void embalagem()
        {
            Console.WriteLine("embalagem é de ilustrada e do no formato cônico");
        }
        public override void preco()
        {
            Console.WriteLine("O custo é de 10 reais. ");

        }

    }

}
