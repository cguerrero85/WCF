using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceLibrary6._2._2016
{
    [ServiceContract]
    public interface IClienteService
    {//Aqui puede ir toda la logica para interactuar con la base de datos
        [OperationContract]
        List<Cliente> ObtenerCliente();
        [OperationContract]
        void insertarCliente(Cliente c);
        [OperationContract]
        void ModificarCliente(Cliente c);
        [OperationContract]
        void EliminarCliente(int id);

    }
}
