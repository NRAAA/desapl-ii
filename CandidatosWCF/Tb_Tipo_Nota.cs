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
    
    public partial class Tb_Tipo_Nota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Tipo_Nota()
        {
            this.Tb_Actividad_Asignada = new HashSet<Tb_Actividad_Asignada>();
        }
    
        public int id_tipo_nota { get; set; }
        public string tipo_nota { get; set; }
        public double peso { get; set; }
        public int status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Actividad_Asignada> Tb_Actividad_Asignada { get; set; }
    }
}
