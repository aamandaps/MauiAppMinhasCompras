//declarando o que vai ser usado
using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        //Atribuindo o tipo de cada produto

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public double Quantidade { get; set; }

        public double Preco { get; set; }

        public double Total { get => Quantidade * Preco; }
    }
}
