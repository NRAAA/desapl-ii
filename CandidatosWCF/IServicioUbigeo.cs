using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CandidatosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbigeo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<Departamento> GetDepartamentos();

        [OperationContract]
        List<Provincia> GetProvincias(String idDepa);

        [OperationContract]
        List<Distrito> GetDistritos(String idDepa, String idProv);

        [OperationContract]
        String ObtenerUbigeo(String idDepa, String idProv, String idDist);
    }

    [DataContract]
    [Serializable]
    public class Departamento
    {
        private String _idDepartamento;
        private String _nomDepartamento;

        [DataMember]
        public String idDepartamento
        {
            get { return _idDepartamento; }
            set { _idDepartamento = value; }
        }

        [DataMember]
        public String nomDepartamento
        {
            get { return _nomDepartamento; }
            set { _nomDepartamento = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class Provincia
    {
        private String _idProvincia;
        private String _nomProvincia;

        [DataMember]
        public String idProvincia
        {
            get { return _idProvincia; }
            set { _idProvincia = value; }
        }

        [DataMember]
        public String nomProvincia
        {
            get { return _nomProvincia; }
            set { _nomProvincia = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class Distrito
    {
        private String _idDistrito;
        private String _nomDistrito;

        [DataMember]
        public String idDistrito
        {
            get { return _idDistrito; }
            set { _idDistrito = value; }
        }

        [DataMember]
        public String nomDistrito
        {
            get { return _nomDistrito; }
            set { _nomDistrito = value; }
        }
    }
}
