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
    
    public partial class Tb_Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Usuario()
        {
            this.Tb_Registro_Usuario = new HashSet<Tb_Registro_Usuario>();
        }
    
        public int id_usuario { get; set; }
        public int id_rol { get; set; }
        public string nick_usuario { get; set; }
        public string pass_usuario { get; set; }
        public int status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Registro_Usuario> Tb_Registro_Usuario { get; set; }
        public virtual Tb_Rol Tb_Rol { get; set; }
    }
}
