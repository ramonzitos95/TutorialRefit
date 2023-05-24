using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoRefit
{
    public interface ICepApi
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> ConsultaCep(string cep);
    }
}
