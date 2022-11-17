using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTuLuz.Entidades
{
    class Proveedor
    {
        private int _id;
        private string _razon_social;
        private string _mail;
        private string _telefono;
        private bool _proveedor_activo;

        public Proveedor(int id, string razonSocial, string mail, string telefono, bool activo)
        {
            _id = id;
            _razon_social = razonSocial;
            _mail = mail;
            _telefono = telefono;
            _proveedor_activo = activo;
        }

        public Proveedor()
        {

        }
        public int Id { get { return _id; } set { _id = value; } }
        public string RazonSocial { get { return _razon_social; } set { _razon_social = value; } }
        public string Mail { get { return _mail; } set { _mail = value; } }
        public string Telefono { get { return _telefono; } set { _telefono = value; } }
        public bool Activo { get { return _proveedor_activo; } set { _proveedor_activo = value; } }




    }
}
