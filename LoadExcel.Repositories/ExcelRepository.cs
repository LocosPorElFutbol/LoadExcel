using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToExcel;
using LoadExcel.Entities;

namespace LoadExcel.Repositories
{
    public class ExcelRepository
    {
        public string pathArchivo { get; set; }

        public ExcelRepository(string _pathArchivo)
        {
            pathArchivo = _pathArchivo;
        }

        public object CargarArchivo(string _hoja)
        {
            try
            {
                var excel = new ExcelQueryFactory(pathArchivo);

                var personas = from p in excel.Worksheet<PersonaExcelEntity>(_hoja)
                               select p;

                return personas.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public object CargarArchivoFuncionaOK1()
        {
            try
            {
                var excel = new ExcelQueryFactory(pathArchivo);

                var personas = from p in excel.Worksheet<PersonaExcelEntity>("BASE TOTAL DE CLIENTES CUMPLE")
                               select p;

                return personas.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object CargarArchivoFuncionaOK()
        {
            try
            {
                var excel = new ExcelQueryFactory(pathArchivo);

                var personas = from p in excel.Worksheet("Hoja1")
                               select new PersonaExcelEntity { nombreCompleto = p["nombreCompleto"] };

                return personas.ToList();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
    }
}
