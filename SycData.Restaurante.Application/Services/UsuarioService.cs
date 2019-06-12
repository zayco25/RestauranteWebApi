using SycData.Restaurante.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Infra.Persistence.Context;
using SycData.Restaurante.Infra.Persistence.Repository;

namespace SycData.Restaurante.Application.Services
{
    public class UsuarioService : IUsuarioService
    {


        private readonly UsuarioRepository _UsuarioRepository;

        public UsuarioService(UsuarioRepository UsuarioRepository)
        {
            _UsuarioRepository = UsuarioRepository;
        }






        public  Task<IEnumerable<Usuario>> GetUser(string Clave)
        {

            return _UsuarioRepository.GetUser(Clave);
        }

       
    }
}
