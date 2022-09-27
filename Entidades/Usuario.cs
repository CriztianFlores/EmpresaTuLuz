using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTuLuz.Entidades
{
    public class Usuario
    {
        private string _username;
        private string _password;
        private int _empleadoId;
        private int _activo;



        public Usuario(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public Usuario(string username, string password, int empleadoId, int activo)
        {
            _username = username;
            _password = password;
            _empleadoId = empleadoId;
            _activo = activo;
        }

        public Usuario()
        {

        }

        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public int EmpleadoId { get { return _empleadoId; } set { _empleadoId = value; } }
        public int Activo { get { return _activo; } set { _activo = value; } }

    }
}
