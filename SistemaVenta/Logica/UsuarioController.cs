using SistemaVenta.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Logica
{

    class UsuarioController
    {
        ventasdbEntities _db = new ventasdbEntities();

        public bool AutenticarUsuario(string pCuenta, string pPassword)
        {
            var reg = _db.Usuario.Where(i => i.Cuenta == pCuenta && i.Password == pPassword).SingleOrDefault();

            if (reg != null)
                return true;
            else
                return false;
        }

    }
}
