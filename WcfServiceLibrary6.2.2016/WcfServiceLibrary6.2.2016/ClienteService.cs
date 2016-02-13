using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace WcfServiceLibrary6._2._2016
{
    [ServiceBehavior]
    public class ClienteService: IClienteService
    {
        private static List<Cliente>listaClientes = new List<Cliente>();
        public List<Cliente> ObtenerCliente()
        {

            return listaClientes;

        }

        public void insertarCliente(Cliente c)
        {
            //Calcula el ID del cliente a ingresar
            if (listaClientes.Count == 0)
            {
                c.IdCliente = 1;
                listaClientes.Add(c);
            }
            else
            {
                //Busca el ultimo cliente toma el id le suma uno
                c.IdCliente = listaClientes.Max(cliente => cliente.IdCliente) + 1;
                listaClientes.Add(c);
            }
            
            //Annade cliente.
            //listaClientes.Add(c);
        }

        public void ModificarCliente(Cliente c)
        {
            Cliente clienteModif = listaClientes.
            Where(cliente => cliente.IdCliente == c.IdCliente).First();
            if (clienteModif != null)
            {
                clienteModif.nombre = c.nombre;
                clienteModif.fechaNacimiento = c.fechaNacimiento;
            }
        }

        public void EliminarCliente(int id)
        {
            Cliente clienteEliminar = listaClientes.
            Where(cliente => cliente.IdCliente == id).First();
            if (clienteEliminar != null)
            {
                listaClientes.Remove(clienteEliminar);
            } 
        }

        /*List<Cliente> IClienteService.ObtenerCliente()
        {
            throw new NotImplementedException();
        }

        void IClienteService.insertarCliente(Cliente c)
        {
            throw new NotImplementedException();
        }

        void IClienteService.ModificarCliente(Cliente c)
        {
            throw new NotImplementedException();
        }

        void IClienteService.EliminarCliente(int id)
        {
            throw new NotImplementedException();
        }*/
    }
}
