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
    
    public partial class Tb_Carrera
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Carrera()
        {
            this.Tb_Curso = new HashSet<Tb_Curso>();
        }
    
        public int id_carrera { get; set; }
        public int id_coordinador { get; set; }
        public int id_facultad { get; set; }
        public string nomb_carrera { get; set; }
        public string desc_carrera { get; set; }
        public Nullable<System.DateTime> fec_creacion { get; set; }
        public int status { get; set; }
    
        public virtual Tb_Coordinador Tb_Coordinador { get; set; }
        public virtual Tb_Facultad Tb_Facultad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Curso> Tb_Curso { get; set; }
    }
}
