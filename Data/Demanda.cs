namespace AgendamentoDemandas.Data
{

    public enum Prioridade
    {
        Baixa,
        Media,
        Alta,
        prioridadeAlta
    }

    public class Demanda
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = ""; 
        public DateTime Data { get; set; } = DateTime.Today;
        public Prioridade prioridades { get; set; } =
            global::AgendamentoDemandas.Data.Prioridade.Baixa; // seta padrao baixa 
        public bool Concluida { get; set; }
    }
}
