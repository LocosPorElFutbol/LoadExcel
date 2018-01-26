using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoadExcel.Business;
using LoadExcel.Entities;

namespace LoadExcel.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonaExcelEntity> listaPersonas = new List<PersonaExcelEntity>();

            listaPersonas = CargarLista();
            foreach (var p in listaPersonas)
            {
                Console.WriteLine("Nombre: " + p.nombreCompleto + ", " + p.apellido + " Cumple dia: " + p.diaCumpleanios);
            }

            Console.ReadKey();
        }

        public static List<PersonaExcelEntity> CargarLista()
        {
            try
            {
                string path = "C:\\Leo\\Dropbox\\Desarrollos\\LandManagement\\Documentos\\Archivos inmobiliaria\\TestImport\\BASE DE DATOS - CUMPLEAÑOS (ACTUAL)Import.xlsx";
                string pathOld = "C:\\Leo\\Dropbox\\Desarrollos\\Librerias\\ImportarExcel\\Pruebas\\BASE DE DATOS - CUMPLEAÑOS (ACTUAL).xlsx";
                ExcelBusiness excelBusiness = new ExcelBusiness(path);
                List<PersonaExcelEntity> lista = (List<PersonaExcelEntity>)excelBusiness.RetornarRowExcel("BASE TOTAL DE CLIENTES CUMPLE");

                foreach (PersonaExcelEntity persona in lista)
                {
                    string nombre = persona.nombreCompleto;
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
