//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CandidatosWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Registro_Usuario
    {
        public int id_usuario { get; set; }
        public System.DateTime fec_ingreso { get; set; }
        public System.DateTime fec_salida { get; set; }
        public int status { get; set; }
    
        public virtual Tb_Usuario Tb_Usuario { get; set; }
    }
}
