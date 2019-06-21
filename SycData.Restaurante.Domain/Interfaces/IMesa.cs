using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Interfaces
{
    public interface IMesa
    {

        Task<IEnumerable<MesaViewModel>> GetMesa(int? IdNivel = 0, int? IdOperacion=0);


        bool ValidarMesa(int IdMesa);




    }
}
