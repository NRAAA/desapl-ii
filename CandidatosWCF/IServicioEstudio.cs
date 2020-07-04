using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

//Created by Nicolás Rojas Artadi

namespace CandidatosWCF
{
  
    [ServiceContract]
    public interface IServicioEstudio
    {
        [OperationContract]
        List<AlumnoCursoBE> ConsultarNotasAlumno(String mvarDni);

        [OperationContract]
        List<AlumnoPorcInasistenciaBE> ConsultarPorcentajeInasistenciaAlumno(String mvarDni);

        [OperationContract]
        List<AlumnoCursoPromBE> ConsultarPromedioPorCursoAlumno(String mvarDni);

    }

    [Serializable]
    [DataContract]
    public class AlumnoCursoBE
    {
        String _nombAlumno;
        String _apeAlumno;
        String _curso;
        String _tituloAct;
        String _temaAct;
        String _descAct;
        Int16 _nota;
        String _tipoNota;
        String _profesor;
        String _comentariosProfesor;

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
        public String Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        [DataMember]
        public String TituloAct
        {
            get { return _tituloAct; }
            set { _tituloAct = value; }
        }

        [DataMember]
        public String TemaAct
        {
            get { return _temaAct; }
            set { _temaAct = value; }
        }

        [DataMember]
        public String DescAct
        {
            get { return _descAct; }
            set { _descAct = value; }
        }

        [DataMember]
        public Int16 Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        [DataMember]
        public String TipoNota
        {
            get { return _tipoNota; }
            set { _tipoNota = value; }
        }

        [DataMember]
        public String Profesor
        {
            get { return _profesor; }
            set { _profesor = value; }
        }

        [DataMember]
        public String ComentariosProfesor
        {
            get { return _comentariosProfesor; }
            set { _comentariosProfesor = value; }
        }
    }

    [Serializable]
    [DataContract]
    public class AlumnoPorcInasistenciaBE
    {
        String _nombAlumno;
        String _apeAlumno;
        String _porcInasist;

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
        public String PorcInasist
        {
            get { return _porcInasist; }
            set { _porcInasist = value; }
        }
    }

    [Serializable]
    [DataContract]
    public class AlumnoCursoPromBE
    {
        String _nombAlumno;
        String _apeAlumno;
        String _profesor;
        String _curso;
        Int16 _promUa;
        Int16 _promEp;
        Int16 _exaParc;
        Int16 _exaFin;
        Int16 _cantInasist;
        Int16 _cantClases;

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
        public String Profesor
        {
            get { return _profesor; }
            set { _profesor = value; }
        }

        [DataMember]
        public String Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        [DataMember]
        public Int16 PromUa
        {
            get { return _promUa; }
            set { _promUa = value; }
        }

        [DataMember]
        public Int16 PromEp
        {
            get { return _promEp; }
            set { _promEp = value; }
        }

        [DataMember]
        public Int16 ExaParc
        {
            get { return _exaParc; }
            set { _exaParc = value; }
        }

        [DataMember]
        public Int16 ExaFin
        {
            get { return _exaFin; }
            set { _exaFin = value; }
        }

        [DataMember]
        public Int16 CantInasist
        {
            get { return _cantInasist; }
            set { _cantInasist = value; }
        }

        [DataMember]
        public Int16 CantClases
        {
            get { return _cantClases; }
            set { _cantClases = value; }
        }
    }
}
