namespace Aula_Classes1
{
    class Pessoa
    {
        //field
        public string nome;
        public int idade;
        public string genero;

        public void Identificar()
        {
            Console.WriteLine($"Olá, sou o {nome} tenho {idade} e sou do sexo {genero}");
        }
    }


}


