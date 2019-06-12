using SycData.Restaurante.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Infra.Persistence.Context;
using System.Data.Entity;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class UsuarioRepository : IUsuario
    {



        RestauranteModel _Context;


        public UsuarioRepository(RestauranteModel Context) {

            _Context = Context;
        }


        public async Task<IEnumerable<Usuario>> GetUser(string Clave)
        {

            var result = await _Context.Usuario.Where(x => x.Clave == Clave).ToListAsync();

            return result;


        }
    }
}
