// Veiculo.cs
public class Veiculo
{
        public Veiculo(string placa, DateTime horaEntrada)
        {
            this.Placa = placa;
                this.HoraEntrada = horaEntrada;
               
        }
        public Veiculo(string placa, DateTime horaEntrada) 
        {
            this.Placa = placa;
                this.HoraEntrada = horaEntrada;
               
        }
                    public string Placa { get; set; }
    public DateTime HoraEntrada { get; set; }

    public Veiculo(string placa)
    {
        Placa = placa;
        HoraEntrada = DateTime.Now;
    }
}
