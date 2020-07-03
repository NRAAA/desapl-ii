using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

//Created by Flavia Figueroa

namespace CandidatosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAlumno" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAlumno
    {
        [OperationContract]
        AlumnoBE ConsultarAlumnoPorDni(String dni);

        [OperationContract]
        AlumnoBE ConsultarAlumnoPorTelefono(String telefono);

        [OperationContract]
        AlumnoBE ConsultarAlumnoPorCorreo(String correo);

        [OperationContract]
        List<AlumnoBE> ConsultarAlumnoPorNombreApellido(String nombre, String apellido);

        [OperationContract]
        List<AlumnoOcurrenciaBE> ConsultarAlumnoOcurrencias(String dni);

        [OperationContract]
        List<AlumnoBE> ConsultarTopCincoAlumnos();
    }

    [Serializable]
    [DataContract]
    public class AlumnoBE
    {
        String _dniAlumno;
        String _nombAlumno;
        String _apeAlumno;
        String _ubiAlumno;
        String _telAlumno;
        String _emailAlumno;
        DateTime _fecInscrip;
        Double _promGlobal;

        [DataMember]
        public String DniAlumno
        {
            get { return _dniAlumno; }
            set { _dniAlumno = value; }
        }

        [DataMember]
        public String NombAlumno
        {
            get { return _nombAlumno; }
            set { _nombAlumno = value; }
        }

        [DataMember]
        public String ApeAlumno
        {
            get { return _apeAlumno; }
            set { _apeAlumno = value; }
        }

        [DataMember]
        public String UbiAlumno
        {
            get { return _ubiAlumno; }
            set { _ubiAlumno = value; }
        }

        [DataMember]
        public String TelAlumno
        {
            get { return _telAlumno; }
            set { _telAlumno = value; }
        }

        [DataMember]
        public String EmailAlumno
        {
            get { return _emailAlumno; }
            set { _emailAlumno = value; }
        }

        [DataMember]
        public DateTime FecInscrip
        {
            get { return _fecInscrip; }
            set { _fecInscrip = value; }
        }

        [DataMember]
        public Double PromGlobal
        {
            get { return _promGlobal; }
            set { _promGlobal = value; }
        }
    }

    [Serializable]
    [DataContract]
    public class AlumnoOcurrenciaBE
    {
        String _nombAlumno;
        String _apeAlumno;
        String _descOcurrencia;
        DateTime _fechaOcurrencia;

        [DataMember]
        public String NombAlumno
        {
            get { return _nombAlumno; }
            set { _nombAlumno = value; }
        }

        [DataMember]
        public String ApeAlumno
        {
            get { return _apeAlumno; }
            set { _apeAlumno = value; }
        }

        [DataMember]
        public String DescOcurrencia
        {
            get { return _descOcurrencia; }
            set { _descOcurrencia = value; }
        }

        [DataMember]
        public DateTime FechaOcurrencia
        {
            get { return _fechaOcurrencia; }
            set { _fechaOcurrencia = value; }
        }
    }
}
