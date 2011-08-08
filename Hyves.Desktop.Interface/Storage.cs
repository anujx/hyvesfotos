using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hyves.Api;
using System.ComponentModel;
using System.IO.IsolatedStorage;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Deployment.Application;

namespace Hyves.Desktop.Interface
{

    public enum StorageData
    {
        [Description("hyvesapplication.binary")]
        HyvesApplication
    }

    public class Storage
    {

        public static HyvesApplication Read(StorageData storageData)
        {
            try
            {
                // Todo : add security and encryption
                IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForAssembly();
                Stream reader = new IsolatedStorageFileStream(EnumHelper.GetDescription(storageData), FileMode.Open, isf);
                IFormatter formatter = new BinaryFormatter();
                HyvesApplication hyvesApplication = (HyvesApplication)formatter.Deserialize(reader);
                reader.Close();

                if (!CheckVersion(hyvesApplication)) 
                {
                    throw new ApplicationException("version are not same");
                }
                return hyvesApplication;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Read", ex);
            }
        }

        private static Version getVersion() 
        {
            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                v = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            return v;
        }
        private static bool CheckVersion(HyvesApplication hyvesApplication) 
        {

            if (hyvesApplication.Version == null || hyvesApplication.Version != getVersion()) 
            {
                return false;
            }
            return true;
        }

        public static void Write(StorageData storageData, HyvesApplication hyvesApplication)
        {
            try
            {
                hyvesApplication.Version = getVersion();
                // Todo : add security and encryption
                IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForAssembly();
                Stream writer = new IsolatedStorageFileStream(EnumHelper.GetDescription(storageData), FileMode.Create, isf);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writer, hyvesApplication);
                writer.Close();
            }
            catch (Exception ex)
            {
                //ToDo: Add logging
                //throw new ApplicationException("Write", ex);
            }
        }
    }
}
