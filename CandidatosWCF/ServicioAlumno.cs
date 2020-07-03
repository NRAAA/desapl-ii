using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

//Created by Flavia Figueroa

namespace CandidatosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAlumno" en el código y en el archivo de configuración a la vez.
    public class ServicioAlumno : IServicioAlumno
    {
        CandidatosIsilEntities candidatosIsilEntities = new CandidatosIsilEntities();
        

        public AlumnoBE ConsultarAlumnoPorDni(String mvarDni)
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

                AlumnoBE objAlumno = new AlumnoBE();
                var query = (from Alumno in candidatosIsilEntities.Tb_Alumno
                             where Alumno.dni_alumno.Equals(mvarDniSeguro) && Alumno.status.Equals(1)
                             select new
                             {
                                 dniAlumno = Alumno.dni_alumno,
                                 nombAlumno = Alumno.nomb_alumno,
                                 apeAlumno = Alumno.ape_alumno,
                                 ubiAlumno = Alumno.ubi_alumno,
                                 telAlumno = Alumno.tel_alumno,
                                 emailAlumno = Alumno.email_alumno,
                                 fecInscrip = Alumno.fec_inscrip,
                                 promGlobal = Alumno.prom_global
                             });

                foreach(var res in query)
                {
                    objAlumno.DniAlumno = res.dniAlumno;
                    objAlumno.NombAlumno = res.nombAlumno;
                    objAlumno.ApeAlumno = res.apeAlumno;
                    objAlumno.UbiAlumno = res.ubiAlumno;
                    objAlumno.TelAlumno = res.telAlumno;
                    objAlumno.EmailAlumno = res.emailAlumno;
                    objAlumno.FecInscrip = res.fecInscrip;
                    objAlumno.PromGlobal = Convert.ToDouble(res.promGlobal);
                }
                return objAlumno;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AlumnoBE ConsultarAlumnoPorTelefono(String mvarTelefono)
        {

            try
            {
                String mvarTelefonoSeguro;

                if (mvarTelefono != "" && mvarTelefono != null)
                {
                    mvarTelefonoSeguro = mvarTelefono;
                }
                else
                {
                    throw new FaultException("Debes consultar un teléfono");
                }

                AlumnoBE objAlumno = new AlumnoBE();
                var query = (from Alumno in candidatosIsilEntities.Tb_Alumno
                             where Alumno.tel_alumno.Equals(mvarTelefonoSeguro) && Alumno.status.Equals(1)
                             select new
                             {
                                 dniAlumno = Alumno.dni_alumno,
                                 nombAlumno = Alumno.nomb_alumno,
                                 apeAlumno = Alumno.ape_alumno,
                                 ubiAlumno = Alumno.ubi_alumno,
                                 telAlumno = Alumno.tel_alumno,
                                 emailAlumno = Alumno.email_alumno,
                                 fecInscrip = Alumno.fec_inscrip,
                                 promGlobal = Alumno.prom_global
                             });

                foreach (var res in query)
                {
                    objAlumno.DniAlumno = res.dniAlumno;
                    objAlumno.NombAlumno = res.nombAlumno;
                    objAlumno.ApeAlumno = res.apeAlumno;
                    objAlumno.UbiAlumno = res.ubiAlumno;
                    objAlumno.TelAlumno = res.telAlumno;
                    objAlumno.EmailAlumno = res.emailAlumno;
                    objAlumno.FecInscrip = res.fecInscrip;
                    objAlumno.PromGlobal = Convert.ToDouble(res.promGlobal);
                }
                return objAlumno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AlumnoBE ConsultarAlumnoPorCorreo(String mvarCorreo)
        {
            try
            {
                String mvarCorreoSeguro;

                if (mvarCorreo != "" && mvarCorreo != null)
                {
                    mvarCorreoSeguro = mvarCorreo;
                }
                else
                {
                    throw new FaultException("Debes consultar un correo");
                }

                AlumnoBE objAlumno = new AlumnoBE();
                var query = (from Alumno in candidatosIsilEntities.Tb_Alumno
                             where Alumno.email_alumno.Equals(mvarCorreoSeguro) && Alumno.status.Equals(1)
                             select new
                             {
                                 dniAlumno = Alumno.dni_alumno,
                                 nombAlumno = Alumno.nomb_alumno,
                                 apeAlumno = Alumno.ape_alumno,
                                 ubiAlumno = Alumno.ubi_alumno,
                                 telAlumno = Alumno.tel_alumno,
                                 emailAlumno = Alumno.email_alumno,
                                 fecInscrip = Alumno.fec_inscrip,
                                 promGlobal = Alumno.prom_global
                             });

                foreach (var res in query)
                {
                    objAlumno.DniAlumno = res.dniAlumno;
                    objAlumno.NombAlumno = res.nombAlumno;
                    objAlumno.ApeAlumno = res.apeAlumno;
                    objAlumno.UbiAlumno = res.ubiAlumno;
                    objAlumno.TelAlumno = res.telAlumno;
                    objAlumno.EmailAlumno = res.emailAlumno;
                    objAlumno.FecInscrip = res.fecInscrip;
                    objAlumno.PromGlobal = Convert.ToDouble(res.promGlobal);
                }
                return objAlumno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoBE> ConsultarAlumnoPorNombreApellido(String nombre, String apellido)
        {
            List<AlumnoBE> objListaAlumnos = new List<AlumnoBE>();
            try
            {
                String nombreSeguro;

                if(nombre != "" && nombre != null)
                {
                    nombreSeguro = nombre;
                }
                else
                {
                    throw new FaultException("Debes consultar un nombre"); 
                }

                String apellidoSeguro;

                if (apellido != "" && apellido != null)
                {
                    apellidoSeguro = apellido;
                }
                else
                {
                    throw new FaultException("Debes consultar un apellido");
                }

                var query = (from Alumno in candidatosIsilEntities.Tb_Alumno
                             where (Alumno.nomb_alumno.ToLower().Contains(nombreSeguro.ToLower()) && Alumno.ape_alumno.ToLower().Contains(apellidoSeguro.ToLower()) && Alumno.status.Equals(1))
                             select new
                             {
                                 dniAlumno = Alumno.dni_alumno,
                                 nombAlumno = Alumno.nomb_alumno,
                                 apeAlumno = Alumno.ape_alumno,
                                 ubiAlumno = Alumno.ubi_alumno,
                                 telAlumno = Alumno.tel_alumno,
                                 emailAlumno = Alumno.email_alumno,
                                 fecInscrip = Alumno.fec_inscrip,
                                 promGlobal = Alumno.prom_global
                             });

                foreach (var res in query)
                {
                    AlumnoBE objAlumno = new AlumnoBE();
                    objAlumno.DniAlumno = res.dniAlumno;
                    objAlumno.NombAlumno = res.nombAlumno;
                    objAlumno.ApeAlumno = res.apeAlumno;
                    objAlumno.UbiAlumno = res.ubiAlumno;
                    objAlumno.TelAlumno = res.telAlumno;
                    objAlumno.EmailAlumno = res.emailAlumno;
                    objAlumno.FecInscrip = res.fecInscrip;
                    objAlumno.PromGlobal = Convert.ToDouble(res.promGlobal);

                    objListaAlumnos.Add(objAlumno);
                }
                return objListaAlumnos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoOcurrenciaBE> ConsultarAlumnoOcurrencias(String dni)
        {
            List<AlumnoOcurrenciaBE> objListaAlumnoOcurrencias = new List<AlumnoOcurrenciaBE>();
            try
            {
                if(dni != "" && dni != null)
                {
                    var query = candidatosIsilEntities.usp_AlumnoOcurrencias(dni);
                    foreach(var res in query)
                    {
                        AlumnoOcurrenciaBE objAlumnoOcurrenciaBE = new AlumnoOcurrenciaBE();
                        objAlumnoOcurrenciaBE.NombAlumno = res.nomb_alumno;
                        objAlumnoOcurrenciaBE.ApeAlumno = res.ape_alumno;
                        objAlumnoOcurrenciaBE.DescOcurrencia = res.ocurrencia;
                        objAlumnoOcurrenciaBE.FechaOcurrencia = Convert.ToDateTime(res.ocu_fecha);
                        objListaAlumnoOcurrencias.Add(objAlumnoOcurrenciaBE);
                    }
                    return objListaAlumnoOcurrencias;
                } else
                {
                    throw new FaultException("Debes consultar un DNI");
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoBE> ConsultarTopCincoAlumnos()
        {
            List<AlumnoBE> objListaAlumnos = new List<AlumnoBE>();
            try
            {
                var query = (from Alumno in candidatosIsilEntities.Tb_Alumno
                             where (Alumno.status.Equals(1))
                             orderby Alumno.prom_global descending
                             select new
                             {
                                 dniAlumno = Alumno.dni_alumno,
                                 nombAlumno = Alumno.nomb_alumno,
                                 apeAlumno = Alumno.ape_alumno,
                                 ubiAlumno = Alumno.ubi_alumno,
                                 telAlumno = Alumno.tel_alumno,
                                 emailAlumno = Alumno.email_alumno,
                                 fecInscrip = Alumno.fec_inscrip,
                                 promGlobal = Alumno.prom_global
                             }).Take(5);
                foreach (var res in query)
                {
                    AlumnoBE objAlumnoBE = new AlumnoBE();
                    objAlumnoBE.DniAlumno = res.dniAlumno;
                    objAlumnoBE.NombAlumno = res.nombAlumno;
                    objAlumnoBE.ApeAlumno = res.apeAlumno;
                    objAlumnoBE.UbiAlumno = res.ubiAlumno;
                    objAlumnoBE.TelAlumno = res.telAlumno;
                    objAlumnoBE.EmailAlumno = res.emailAlumno;
                    objAlumnoBE.FecInscrip = res.fecInscrip;
                    objAlumnoBE.PromGlobal = Convert.ToDouble(res.promGlobal);
                    objListaAlumnos.Add(objAlumnoBE);
                }
                return objListaAlumnos;
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
