using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDI_Tarea_6
{
    /// <summary>
    /// Clase destinada a guardar los datos no persistentes del formulario de registro. Para ello consta de una clase "MacGuiffin", que debe su nombre al 
    /// recurso narrativo que desarrolló Alfred Hitchcock en su peliculas, proveniente del mundo dela magia y el ilusionismo, en la que un elemento a lo
    /// largo de la pelicula parecia que llevaba toda la carga narrativa de la pelicula y que era esencial para su trama, pero que al final solo resultaba 
    /// ser una maniobra de distraccion para despistar al espectador. 
    /// 
    /// La clase MacGuffin esta compuesta de los atributos que corresponden a los campos de datos, su metodo constructor y sus metodos getters y setters
    /// </summary>
    internal class MacGuffin
    {
        private string _strNombre, _strPrimerApellido, _strSegund9oApellido, _strNacionalidad;
        private bool _blnTortilla;
        private string _dtmNacimiento;

        public MacGuffin(string strNombre, string strPrimerApellido, string strSegund9oApellido, string strNacionalidad, bool blnTortilla, string dtmNacimiento)
        {
            _strNombre = strNombre;
            _strPrimerApellido = strPrimerApellido;
            _strSegund9oApellido = strSegund9oApellido;
            _strNacionalidad = strNacionalidad;
            _blnTortilla = blnTortilla;
            _dtmNacimiento = dtmNacimiento;
        }

        public bool BlnTortilla { get => _blnTortilla; set => _blnTortilla = value; }
        public string StrNombre { get => _strNombre; set => _strNombre = value; }
        public string StrPrimerApellido { get => _strPrimerApellido; set => _strPrimerApellido = value; }
        public string StrSegund9oApellido { get => _strSegund9oApellido; set => _strSegund9oApellido = value; }
        public string StrNacionalidad { get => _strNacionalidad; set => _strNacionalidad = value; }
        public string DtmNacimiento { get => _dtmNacimiento; set => _dtmNacimiento = value; }
    }
}
