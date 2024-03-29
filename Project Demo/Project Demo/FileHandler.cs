using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Demo
{
    class FileHandler
    {
         FileStream stream;
        StreamReader reader;
        StreamWriter writer;
        public List<string> ReadData(string fileName)
        {
            List<string> rawData = new List<string>();
            
            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);
                string line = string.Empty;
                while ((line=reader.ReadLine())!= null)
                {
                   
                    rawData.Add(line);
                }
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show(dnfe.Message);
            }
            finally
            {
                
                


                reader.Close();
                stream.Close(); 
            }

            return rawData;
        }
        public void WriteData(string fileName, string dataToWrite)
        {
            try
            {
                stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(stream);
                writer.WriteLine(dataToWrite);
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show(dnfe.Message);
            }
            finally
            {
                
                writer.Close();
                stream.Close();
            }

        }
        public void UpdateData(string fileName, string dataToUpdate)
        {
            stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);

        }
    }
}
