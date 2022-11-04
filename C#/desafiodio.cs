namespace desafio.models
{
    public class pessoa
    {
        public string Name {get; set;}
        public int Idade {get; set;}
        
        public void Apresentar()
        {
            Console.WriteLine ($"Olá, meu nome é {Name} e tenho {Idade} anos.");
        }
    }
}