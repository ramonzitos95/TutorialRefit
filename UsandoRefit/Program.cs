
using Refit;
using UsandoRefit;

Console.WriteLine("Digite o CEP.....");
var cep = Console.ReadLine();

var servico = RestService.For<ICepApi>("https://viacep.com.br");
var retorno = await servico.ConsultaCep(cep);

if(retorno != null)
{
    Console.WriteLine($"Logradouro: {retorno.Logradouro}");
    Console.WriteLine($"Bairro: {retorno.Bairro}");
    Console.WriteLine($"Cidade: {retorno.Localidade}");
    Console.WriteLine($"Estado: {retorno.UF}");
}
