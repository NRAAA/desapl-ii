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
    
    public partial class Tb_Estudio
    {
        public int id_alumno { get; set; }
        public int id_curso_prog { get; set; }
        public System.DateTime fec_matricula { get; set; }
        public Nullable<int> prom_ua { get; set; }
        public Nullable<int> prom_ep { get; set; }
        public Nullable<int> exa_parc { get; set; }
        public Nullable<int> exa_fin { get; set; }
        public Nullable<int> nota_fin { get; set; }
        public int cant_inasist { get; set; }
        public int status { get; set; }
    
        public virtual Tb_Alumno Tb_Alumno { get; set; }
        public virtual Tb_Curso_Programado Tb_Curso_Programado { get; set; }
    }
}
