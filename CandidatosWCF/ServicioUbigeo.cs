using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CandidatosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbigeo" en el código y en el archivo de configuración a la vez.
    public class ServicioUbigeo : IServicioUbigeo
    {
        UBIGEOEntities miUbigeo = new UBIGEOEntities();
        CandidatosIsilEntities candidatosIsilEntities = new CandidatosIsilEntities();


        public List<Departamento> GetDepartamentos()
        {
            
            List<Departamento> objListaDepartamentos = new List<Departamento>();

            try
            {
                var query = miUbigeo.UBIGEO_DEPARTAMENTOS();

                foreach (var resultado in query)
                {
                    Departamento objDepartamento = new Departamento();
                    objDepartamento.idDepartamento = resultado.IDDEPA;
                    objDepartamento.nomDepartamento = resultado.DEPARTAMENTO;

                    objListaDepartamentos.Add(objDepartamento);
                }
                return objListaDepartamentos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Provincia> GetProvincias(String idDepa)
        {
            List<Provincia> objListaProvincias = new List<Provincia>();

            try
            {
                String idDepaSeguro;

                if (idDepa != "" && idDepa != null)
                {
                    idDepaSeguro = idDepa;
                }
                else
                {
                    throw new FaultException("Debes consultar un departamento");
                }

                var query = miUbigeo.UBIGEO_PROVINCIASDEPARTAMENTO(idDepaSeguro);

                foreach (var resultado in query)
                {
                    Provincia objProvincia = new Provincia();
                    objProvincia.idProvincia = resultado.IDPROV;
                    objProvincia.nomProvincia = resultado.PROVINCIA;

                    objListaProvincias.Add(objProvincia);
                }
                return objListaProvincias;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Distrito> GetDistritos(String idDepa, String idProv)
        {
            List<Distrito> objListaDistritos = new List<Distrito>();


            try
            {
                String idDepaSeguro;

                if (idDepa != "" && idDepa != null)
                {
                    idDepaSeguro = idDepa;
                }
                else
                {
                    throw new FaultException("Debes consultar un departamento");
                }

                String idProvSeguro;

                if (idProv != "" && idProv != null)
                {
                    idProvSeguro = idProv;
                }
                else
                {
                    throw new FaultException("Debes consultar una provincia");
                }

                var query = miUbigeo.UBIGEO_DISTRITOSPROVINCIA(idDepaSeguro, idProvSeguro);

                foreach (var resultado in query)
                {
                    Distrito objDistrito = new Distrito();
                    objDistrito.idDistrito = resultado.IDDIST;
                    objDistrito.nomDistrito = resultado.DISTRITO;

                    objListaDistritos.Add(objDistrito);
                }
                return objListaDistritos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public String ObtenerUbigeo(String idDepa, String idProv, String idDist)
        {
            String ubigeoCadena = "";
            try
            {
                if(idDepa != "" && idDepa != null && idProv != "" && idProv != null && idDist != "" && idDist != null)
                {
                    var query = miUbigeo.usp_UbigeoCadena(idDepa, idProv, idDist);

                    foreach (var res in query)
                    {
                        ubigeoCadena = res.Departamento + " - " + res.Provincia + " - " + res.Distrito;
                    }
                    return ubigeoCadena;
                } else
                {
                    throw new FaultException("Debes consultar un ubigeo");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
