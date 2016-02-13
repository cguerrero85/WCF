using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization; //Que la clase completa se comporte como un contrato

namespace WcfServiceLibrary6._2._2016
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCliente;
        [DataMember]
        public string nombre;
        [DataMember]
        public String fechaNacimiento; 
    }

}
