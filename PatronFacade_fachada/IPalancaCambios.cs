using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFacade_fachada
{
    public interface IPalancaCambios
    {
        void InsertarVelocidad(int velocidad);
        void PuntoMuerto();
        int GetVelocidadActual();
    }
}