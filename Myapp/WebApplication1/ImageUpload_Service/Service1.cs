using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ImageUpload_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : ImageUploadService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool UploadFileData(FileData fileData)
        {
            bool result = false;
            try
            {
                string FilePath = Path.Combine(ConfigurationManager.AppSettings["PATH"], fileData.FileName);
                if (fileData.FilePosition == 0)
                {
                    CreateDirectoryIfNotExists(FilePath);
                    File.Create(FilePath).Close();
                }
                using (FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
                {
                    fileStream.Seek(fileData.FilePosition, SeekOrigin.Begin);
                    fileStream.Write(fileData.BufferData, 0, fileData.BufferData.Length);
                }
            }
            catch (Exception ex)
            {
                ErrorDetails ed = new ErrorDetails();
                ed.ErrorCode = 1001;
                ed.ErrorMessage = ex.Message;
                throw new FaultException<ErrorDetails>(ed);
            }

            return result;
        }

        private void CreateDirectoryIfNotExists(string filePath)
        {
            var directory = new FileInfo(filePath).Directory;
            if (directory == null) throw new Exception("Directory could not be determined for the filePath");

            Directory.CreateDirectory(directory.FullName);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
