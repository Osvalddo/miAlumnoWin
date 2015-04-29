using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miAlumnoWin
{
    class Alumno
    {
        private int legajo;
        private string nombre;
        private int documento;
        private double nota1, nota2;
        private int tipoDoc;
        private DateTime fechaNac;

        //Métodos
        public void rendir()
        {
            //Falta programar
        }

        public void cursar() { }

        public double calcularPromedio()
        { return (nota1 + nota2) / 2; }

        // Propiedades
        public int pLegajo
        {
            set { legajo = value; }
            get { return legajo; }
        }

        public string pNombre
        { set { nombre = value; }
          get { return nombre; }    
        }

        public int pDocumento
        {
            set { documento = value; }
            get { return documento; }
        }

        public double pNota1 { set { nota1 = value; } get { return nota1; } }
        public double pNota2 { set { nota2 = value; } get { return nota2; } }

        public int pTipoDoc { set { tipoDoc = value; } get { return tipoDoc; } }
        //quiero pasar unicamente la fecha, sin la hora. Usar: ToString("dd/MM/yyyy") (lo uso en el return del mensaje)
        public DateTime pFechaNac { set { fechaNac = value; } get { return fechaNac; } }

        //Constructores
        public Alumno()
        {
            legajo = 0;
            nombre = "";
            documento = 0;
            nota1 = nota2 = 0.0;
            tipoDoc = 0;
            fechaNac = DateTime.Today;
        }

        public Alumno(int leg) // constructor con parametros, son privados dentro del block alumnos...
        {
            legajo = leg;
            nombre = "";
            documento = 0;
        }

        public Alumno(int leg, string nom, int doc, int tdoc, DateTime fnac, double not1, double not2)
        {
            legajo = leg;
            nombre = nom;
            documento = doc;
            tipoDoc = tdoc;
            fechaNac = fnac;
            nota1 = not1;
            nota2 = not2;
        }

        public void Notas(double not1, double not2)
        {
            nota1=not1;
            nota2=not2;
        }

        public string toString() // todo lleva a texto.
        {
            return "Legajo: " + legajo + "\nNombre: " + nombre + "\nNacido el: " + fechaNac.ToString("dd/MM/yyyy") + "\nTipo de Doc: " + tipoDoc + "\nDocumento: " + documento + "\nPromedio: " + calcularPromedio();
        }

                
    }
}
