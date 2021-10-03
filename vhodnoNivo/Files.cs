using System;
using System.Collections.Generic;
using System.IO;

namespace vhodnoNivo
{
    class Files
    {
        private string fileName;

        public Files(string fileName)
        {
            this.fileName = fileName;
        }
        public void WriteToFile(List<string> data)
        {
            var writer = new StreamWriter(this.fileName);

            foreach(var line in data)
            {
                writer.WriteLine(line);
            }
            writer.Close();
        }

        public List<string> ReadToFile()
        {
            List<string> data = new List<string>();

            try
            {
                var reader = new StreamReader(this.fileName);

                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                        break;

                    data.Add(line);
                }
                reader.Close();
            }
            catch (InvalidCastException e)
            {
                
            }

            return data;
        }
    }
}
