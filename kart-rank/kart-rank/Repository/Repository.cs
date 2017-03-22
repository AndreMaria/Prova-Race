using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace kart_rank.Repository
{
    public class Repository
    {
        #region
        public delegate T ReaderData<T>(String line);

        //
        //public List<T> ReaderFile<T>()
        public List<T> ReaderFile<T>(ReaderData<T> readerData)
        {
            FileStream file = null;
            StreamReader reader = null;
            List<T> list = new List<T>();
            try
            {
                file = new FileStream(ConfigurationManager.AppSettings["path"].ToString(), FileMode.Open);
                reader = new StreamReader(file);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var item = readerData(line);
                    if (null != item)
                    {
                        list.Add(readerData(line));
                    }

                    Console.WriteLine(line); // Write to console.
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (null != reader)
                {
                    reader.Close();
                    reader.Dispose();
                }

                if (null != file)
                {
                    file.Close();
                    file.Dispose();
                }
            }
            return list;
        }
        #endregion
    }
}