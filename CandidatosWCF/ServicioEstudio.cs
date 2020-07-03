using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

//Created by Nicolás Rojas Artadi

namespace CandidatosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEstudio" en el código y en el archivo de configuración a la vez.
    public class ServicioEstudio : IServicioEstudio
    {
        CandidatosIsilEntities candidatosIsilEntities = new CandidatosIsilEntities();

        public List<AlumnoCursoBE> ConsultarNotasAlumno(String mvarDni)
        {
            List<AlumnoCursoBE> objListaAlumnoCursoBE = new List<AlumnoCursoBE>();
            try
            {
                String mvarDniSeguro;

                if (mvarDni != "" && mvarDni != null)
                {
                    mvarDniSeguro = mvarDni;
                }
                else
                {
                    throw new FaultException("Debes consultar un DNI");
                }

                var query = candidatosIsilEntities.usp_AlumnoNotasDni(mvarDniSeguro);

                foreach(var res in query)
                {
                    AlumnoCursoBE objAlumnoCursoBE = new AlumnoCursoBE();
                    objAlumnoCursoBE.NombAlumno = res.nomb_alumno;
                    objAlumnoCursoBE.ApeAlumno = res.ape_alumno;
                    objAlumnoCursoBE.ComentariosProfesor = res.comentarios_profesor;
                    objAlumnoCursoBE.Curso = res.curso;
                    objAlumnoCursoBE.DescAct = res.desc_act;
                    objAlumnoCursoBE.Nota = Convert.ToInt16(res.nota);
                    objAlumnoCursoBE.Profesor = res.profesor;
                    objAlumnoCursoBE.TemaAct = res.tema_act;
                    objAlumnoCursoBE.TipoNota = res.tipo_nota;
                    objAlumnoCursoBE.TituloAct = res.titulo_act;

                    objListaAlumnoCursoBE.Add(objAlumnoCursoBE);
                }

                return objListaAlumnoCursoBE;

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AlumnoPorcInasistenciaBE ConsultarPorcentajeInasistenciaAlumno(String mvarDni)
        {
            try
            {
                String mvarDniSeguro;

                if (mvarDni != "" && mvarDni != null)
                {
                    mvarDniSeguro = mvarDni;
                }
                else
                {
                    throw new FaultException("Debes consultar un DNI");
                }

                AlumnoPorcInasistenciaBE objAlumnoPorcInasistenciaBE = new AlumnoPorcInasistenciaBE();

                var query = candidatosIsilEntities.usp_AlumnoPorcInasistDni(mvarDniSeguro);

                foreach(var res in query)
                {
                    objAlumnoPorcInasistenciaBE.ApeAlumno = res.ape_alumno;
                    objAlumnoPorcInasistenciaBE.NombAlumno = res.nomb_alumno;
                    objAlumnoPorcInasistenciaBE.PorcInasist = res.porc_inasist;
                }
                return objAlumnoPorcInasistenciaBE;

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AlumnoCursoPromBE ConsultarPromedioPorCursoAlumno(String mvarDni)
        {
            try
            {
                String mvarDniSeguro;

                if (mvarDni != "" && mvarDni != null)
                {
                    mvarDniSeguro = mvarDni;
                }
                else
                {
                    throw new FaultException("Debes consultar un DNI");
                }

                AlumnoCursoPromBE objAlumnoCursoPromBE = new AlumnoCursoPromBE();

                var query = candidatosIsilEntities.usp_AlumnoPromedioCursoDni(mvarDniSeguro);

                foreach(var res in query)
                {
                    objAlumnoCursoPromBE.ApeAlumno = res.ape_alumno;
                    objAlumnoCursoPromBE.CantClases = Convert.ToInt16(res.cant_clases);
                    objAlumnoCursoPromBE.CantInasist = Convert.ToInt16(res.cant_inasist);
                    objAlumnoCursoPromBE.Curso = res.curso;
                    objAlumnoCursoPromBE.ExaFin = Convert.ToInt16(res.exa_fin);
                    objAlumnoCursoPromBE.ExaParc = Convert.ToInt16(res.exa_parc);
                    objAlumnoCursoPromBE.NombAlumno = res.nomb_alumno;
                    objAlumnoCursoPromBE.Profesor = res.profesor;
                    objAlumnoCursoPromBE.PromEp = Convert.ToInt16(res.prom_ep);
                    objAlumnoCursoPromBE.PromUa = Convert.ToInt16(res.prom_ua);
                }
                return objAlumnoCursoPromBE;

            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
