﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class UBIGEOEntities : DbContext
    {
        public UBIGEOEntities()
            : base("name=UBIGEOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<UBIGEO_CIUDADESPAIS_Result> UBIGEO_CIUDADESPAIS(string idContinente, string idPais)
        {
            var idContinenteParameter = idContinente != null ?
                new ObjectParameter("IdContinente", idContinente) :
                new ObjectParameter("IdContinente", typeof(string));
    
            var idPaisParameter = idPais != null ?
                new ObjectParameter("IdPais", idPais) :
                new ObjectParameter("IdPais", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UBIGEO_CIUDADESPAIS_Result>("UBIGEO_CIUDADESPAIS", idContinenteParameter, idPaisParameter);
        }
    
        public virtual ObjectResult<UBIGEO_CONTINENTE_Result> UBIGEO_CONTINENTE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UBIGEO_CONTINENTE_Result>("UBIGEO_CONTINENTE");
        }
    
        public virtual ObjectResult<UBIGEO_DEPARTAMENTOS_Result> UBIGEO_DEPARTAMENTOS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UBIGEO_DEPARTAMENTOS_Result>("UBIGEO_DEPARTAMENTOS");
        }
    
        public virtual ObjectResult<UBIGEO_DISTRITOSPROVINCIA_Result> UBIGEO_DISTRITOSPROVINCIA(string idDepartamento, string idProvincia)
        {
            var idDepartamentoParameter = idDepartamento != null ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(string));
    
            var idProvinciaParameter = idProvincia != null ?
                new ObjectParameter("IdProvincia", idProvincia) :
                new ObjectParameter("IdProvincia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UBIGEO_DISTRITOSPROVINCIA_Result>("UBIGEO_DISTRITOSPROVINCIA", idDepartamentoParameter, idProvinciaParameter);
        }
    
        public virtual ObjectResult<UBIGEO_PAISESCONTINENTE_Result> UBIGEO_PAISESCONTINENTE(string idContinente)
        {
            var idContinenteParameter = idContinente != null ?
                new ObjectParameter("IdContinente", idContinente) :
                new ObjectParameter("IdContinente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UBIGEO_PAISESCONTINENTE_Result>("UBIGEO_PAISESCONTINENTE", idContinenteParameter);
        }
    
        public virtual ObjectResult<UBIGEO_PROVINCIASDEPARTAMENTO_Result> UBIGEO_PROVINCIASDEPARTAMENTO(string idDepartamento)
        {
            var idDepartamentoParameter = idDepartamento != null ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UBIGEO_PROVINCIASDEPARTAMENTO_Result>("UBIGEO_PROVINCIASDEPARTAMENTO", idDepartamentoParameter);
        }
    
        public virtual ObjectResult<usp_UbigeoCadena_Result> usp_UbigeoCadena(string vdepa, string vprov, string vdist)
        {
            var vdepaParameter = vdepa != null ?
                new ObjectParameter("vdepa", vdepa) :
                new ObjectParameter("vdepa", typeof(string));
    
            var vprovParameter = vprov != null ?
                new ObjectParameter("vprov", vprov) :
                new ObjectParameter("vprov", typeof(string));
    
            var vdistParameter = vdist != null ?
                new ObjectParameter("vdist", vdist) :
                new ObjectParameter("vdist", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UbigeoCadena_Result>("usp_UbigeoCadena", vdepaParameter, vprovParameter, vdistParameter);
        }
    }
}
