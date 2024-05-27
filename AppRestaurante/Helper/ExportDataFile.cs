using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante.Helper
{
    public class ExportDataFile
    {
       

        public string validarCargaArchivo(OpenFileDialog openFileDialog, string filepath)
        {
            if (openFileDialog != null)
            {
                return openFileDialog.FileName;
            }
            else
            {
                openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                return $"{openFileDialog.InitialDirectory}\\{filepath}";
            }
        }

        public void ExportarTxt(string filename, DataGridView registros)
        {
            using (TextWriter fileW = new StreamWriter(filename))
            {
                int i, j = 0;
                for (i = 0; i < registros.Rows.Count - 1; i++)
                {
                    for (j = 0; j < registros.Columns.Count; j++)
                    {
                        if (j == registros.Rows.Count - 1)
                        {
                            fileW.Write($"\t{registros.Rows[i].Cells[j].Value.ToString()}");
                        }
                        else
                        {
                            fileW.Write($"\t{registros.Rows[i].Cells[j].Value.ToString()}\t|");
                        }
                    }
                    fileW.WriteLine(" ");
                }
                fileW.Close();
            }
        }        
    }
}
