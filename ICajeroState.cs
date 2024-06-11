using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public interface ICajeroState
    {
        void IniciarSesion(string pin);
        void SeleccionarOperacion();
        void RealizarOperacion();
        void CerrarSesion();
        void VerificarSaldo();

    }
}
