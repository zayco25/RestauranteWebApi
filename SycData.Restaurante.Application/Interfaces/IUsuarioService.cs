using SycData.Restaurante.Infra.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Application.Interfaces
{
   public interface IUsuarioService
    {

        Task<IEnumerable<Usuario>> GetUser(string Clave);
    }
}
