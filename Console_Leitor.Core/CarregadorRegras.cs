using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Console_Leitor.Core
{
    public record RegrasJogo(Dictionary<string,List<string>>VenceContra);
    
    public interface ICarregadorRegras
    {
       public Task<RegrasJogo> DeterminarRegras();
    }
    public class CarregadorRegras:ICarregadorRegras
    {
        public readonly string _definicoesRegras;
        public CarregadorRegras(string definicoesRegras)
        {
            _definicoesRegras = definicoesRegras;
        }
        public Task<RegrasJogo> DeterminarRegras()
        {
            var regras = JsonSerializer.Deserialize < Dictionary<string, List<string>>>(_definicoesRegras, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return Task.FromResult(new RegrasJogo(regras!));
        }

    }
}
