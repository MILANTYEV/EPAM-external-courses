using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class FileOwner
    {
        private StreamReader _reader;
        private StreamWriter _writer;
        private string _fileName;

        public FileOwner(string fileName)
        {
            this._fileName = fileName;
        }
        
        public List<string> GetFileText()
        {
            List<string> textList = new List<string>();
            try
            {
                _reader = new StreamReader(_fileName);
                while (!_reader.EndOfStream)
                {
                    textList.Add(_reader.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _reader.Close();
            }
            return textList;
        }

        public void RecordFile(List<string> newText)
        {
            try
            {
                _writer = new StreamWriter(_fileName);
                foreach (var line in newText)
                {
                    _writer.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _writer.Close();
            }
        }
    }
}
