using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashProp
{
    public partial class HashWindow : Form
    {
        bool _hashingAllowed = true;
        System.Timers.Timer _timer = new System.Timers.Timer(80);
        TextBox _currentTextBox;
        private string _filePath;

        public HashWindow(string file)
        {
            _filePath = file;

            InitializeComponent();
            AboutLabel.Text = "HashProp v" + GetType().Assembly.GetName().Version.ToString(3) + " by ARKconcepts";
            this.Text = Path.GetFileName(file) + " Hashes";

            _timer.AutoReset = false;
            _timer.SynchronizingObject = this;
            _timer.Elapsed += new System.Timers.ElapsedEventHandler((s, e) =>
            {
                this.Invoke(new Action(() =>
                {
                    if (_currentTextBox != null && !_currentTextBox.Text.Contains("..."))
                        _currentTextBox.SelectAll();
                }));
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            HashingAllowed = false;
            base.OnClosed(e);
        }

        private bool HashingAllowed
        {
            get
            {
                lock (this)
                {
                    return _hashingAllowed;
                }
            }
            set
            {
                lock (this)
                {
                    _hashingAllowed = value;
                }
            }
        }
        private async Task<string> GetHash<T>(string path, IProgress<int> progress) where T : HashAlgorithm
        {
            using (HashAlgorithm hasher = Activator.CreateInstance<T>())
            {
                hasher.Initialize();
                var hash = await Task.Run(() =>
                {
                    try
                    {
                        var fileLength = new FileInfo(path).Length;
                        using (var file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                        using (var cs = new CryptoStream(file, hasher, CryptoStreamMode.Read))
                        {
                            var buf = new byte[4096];
                            var pos = 0L;
                            var lastReport = DateTime.UtcNow.AddMinutes(-1);
                            while (pos < fileLength && HashingAllowed)
                            {
                                pos += cs.Read(buf, 0, buf.Length);

                                // Do not report more often than once per 100ms in order to lessen the load on the UI thread.
                                if (DateTime.UtcNow.Subtract(lastReport).Milliseconds > 100)
                                {
                                    progress.Report((int)Math.Floor(100.0 * pos / fileLength));
                                    lastReport = DateTime.UtcNow;
                                }
                            }
                            cs.Close();

                            // Return an empty string if hashing was stopped.
                            if (pos < fileLength) return "";

                            return BitConverter.ToString(hasher.Hash).Replace("-", "");
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                });
                return hash;
            }
        }

        private async void CalcMd5_Click(object sender, EventArgs e)
        {
            CalcMd5.Enabled = false;
            Md5Output.Text = "Calculating...";
            Md5Output.Text = await GetHash<MD5Cng>(_filePath, new Progress<int>(p => Md5Output.Text = "Calculating... " + p + "%"));
            Md5Output.SelectAll();
            CalcMd5.Enabled = true;
        }

        private async void CalcSha1_Click(object sender, EventArgs e)
        {
            CalcSha1.Enabled = false;
            Sha1Output.Text = "Calculating...";
            Sha1Output.Text = await GetHash<SHA1Cng>(_filePath, new Progress<int>(p => Sha1Output.Text = "Calculating... " + p + "%"));
            Sha1Output.SelectAll();
            CalcSha1.Enabled = true;
        }

        private async void CalcSha256_Click(object sender, EventArgs e)
        {
            CalcSha256.Enabled = false;
            Sha256Output.Text = "Calculating...";
            Sha256Output.Text = await GetHash<SHA256Cng>(_filePath, new Progress<int>(p => Sha256Output.Text = "Calculating... " + p + "%"));
            Sha256Output.SelectAll();
            CalcSha256.Enabled = true;
        }

        private async void CalcSha512_Click(object sender, EventArgs e)
        {
            CalcSha512.Enabled = false;
            Sha512Output.Text = "Calculating...";
            Sha512Output.Text = await GetHash<SHA512Cng>(_filePath, new Progress<int>(p => Sha512Output.Text = "Calculating... " + p + "%"));
            Sha512Output.SelectAll();
            CalcSha512.Enabled = true;
        }

        private void HashOutput_Enter(object sender, EventArgs e)
        {
            _currentTextBox = (TextBox)sender;
            _timer.Start();
        }
    }
}
