using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * El Espacio de Nombre lo arma de manera automatica concatenando el nombre del proyecto y el nombre de la carpeta contenedora
 */
namespace ConsoleAppVehiculos.Interfaces
{
    /// <summary>
    /// Es una Interface que describe el comportamiento de un SERVICE de un Vehiculo
    /// Por convencion, las Interfaces empiezan con la letra I<nombre>
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Funcionalidad para cambiar una rueda, sin implementacion
        /// </summary>
        void cambiarRueda();

        /// <summary>
        /// Funcionalidad para alinear una rueda, sin implementacion
        /// </summary>
        void alinear();

        /// <summary>
        /// Funcionalidad para medir la presion, sin implementacion
        /// </summary>
        void medirPresion();

    }
}
