namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string placa = Console.ReadLine();

            if((string.IsNullOrEmpty(placa) ) || (placa == ""))
            {
                Console.WriteLine("Gentileza informar uma placa válida.");
            }
            else
            {
                veiculos.Add(placa.ToUpper());
            }
           

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");


            string placa = "";
            placa = Console.ReadLine().ToUpper();

            if ((string.IsNullOrEmpty(placa)) || (placa == ""))
            {
                Console.WriteLine("Gentileza informar uma placa válida.");
            }
            else
            {
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    int horas = 0;
                    decimal valorTotal = 0;

                    horas = int.Parse(Console.ReadLine());

                    valorTotal = (precoInicial + (precoPorHora * horas));

                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }

            
        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                int cont = 0;
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    cont++;
                    Console.WriteLine($"{cont} - {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
