using System;
using System.Collections.Generic;
using System.Text;
using SBPGPKeys;
using SBPGPUtils;
using SBUtils;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using SBPGP;
#region
/***
 * 02/02/2019:  Bug fix.. Encryption created zero bytes files due to error. I tried to decrypt them unknowingly and replaced to zero bytes raw files. Loosing everything
 * 02/28/2020: tried to use Multi-threading
***/
#endregion


namespace PGPEncrypter
{
    public partial class Form1 : Form
    {

        private const string PublicKey =
@"-----BEGIN PGP PUBLIC KEY BLOCK-----
Version: PGP Desktop 9.12.0 (Build 1035) - not licensed for commercial use: www.pgp.com

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
QepRqGMOmcJaQULMKOwvmbJMzQ==
=qW+D
-----END PGP PUBLIC KEY BLOCK-----";
        private const string PrivateKey =
    @"-----BEGIN PGP PRIVATE KEY BLOCK-----
Version: PGP Desktop 9.12.0 (Build 1035) - not licensed for commercial use: www.pgp.com

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
=WpXy
-----END PGP PRIVATE KEY BLOCK-----";

        private TElPGPKeyring _EncKeyring = new TElPGPKeyring();
        private TElPGPKeyring Keyring = new TElPGPKeyring() { ArmorBoundary = "", SaveSecretKeySignatures = false, WriteTrust = true };
        private int _FileCount = 0;
        private int _Errors = 0;
        private int RefreshInSeconds = 10;
        private DateTime _Now;


        public Form1()
        {
            InitializeComponent();

            //License Key for this PGP software.
            SBUtils.Unit.SetLicenseKey("A00CF83C5B582EAF13D694E31970FB2BAF1893787BC70D56E0A8CD494BE02A46DB31FDB5D201EF9891D22738D4E48444824883E3A86ECD8F781AD74F7681AAAFED6D6EF7F9D7CDCF3A8F3259E0F1B0BE7CD55EBFB2E1E2F81E183856CF39EEC210688EB4A71B70603F4A76E382210BCD660182C34FF462F6E2B3EB335499E7C5356F863E505C86FB9D272E9D1BB70AE41441598B9C75767FDEB4C60EC282A2A3461DBA43A4EE1123E1F141747C64DC359D0AFD4A55F9C8FD71E19958187194D82B9E507F4B24D926A69D0597C0DD1CD146F523A4542D81F408CE41421813339AF45347AB2B012BECF67581CA74F2167CC2AE7BC6EF152185994684D670FF4F3D");

            Keyring.AddSecretKey(GetPrivateKey(PrivateKey));
            Keyring.AddPublicKey(GetPublicKey(PublicKey)); //public key seems to be optional
            _EncKeyring.AddPublicKey(GetPublicKey(PublicKey));

            _Now = DateTime.Now.AddSeconds(RefreshInSeconds);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //recursive function
        private void DirSearchAndDecrypt(string sDir)
        {
            List<Task> tasks = new List<Task>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    Application.DoEvents();

                    Task t = Task.Run(() =>
                    {
                        if (f.ToLower().EndsWith(".pgp") && new FileInfo(f).Length > 0)
                        {
                            try
                            {
                                if (Decrypt(f))
                                {
                                    File.Delete(f);
                                    _FileCount++;
                                }
                                else
                                {
                                    _Errors++;
                                }
                            }
                            catch (Exception ex)
                            {
                                //log error
                            }
                        }

                    });

                    tasks.Add(t);

                    if (DateTime.Now > _Now)
                    {
                        RefreshMessage();
                    }
                }

                Task.WaitAll(tasks.ToArray());  //wait until all above tasks are complete

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    //process subdirectories
                    DirSearchAndDecrypt(d);
                }
            }
            catch (Exception ex)
            {
                Task asyncTask = WriteToLogFileAsync(string.Format("Dir:{0} Error:{1}", sDir, ex.Message));
            }
        }

        private bool DecryptFolderSubFolders(string RootFolder)
        {
            try
            {
                DirSearchAndDecrypt(RootFolder);
            }
            finally
            {
                //_EncKeyring.Dispose();  //do this when different keys are used. assign new key before pgpwriter or pgpreader is used again 
            }

            RefreshMessage(true, true);
            return true;
        }

        private bool Decrypt(string sourceFile)
        {
            bool bSuccess = false;

            FileStream streamInput = null;
            string pgpFile = sourceFile.Replace(".pgp", "");

            try
            {
                streamInput = new FileStream(sourceFile, FileMode.Open);
                FileStream streamOutput = new FileStream(pgpFile, FileMode.Create);
                try
                {
                    // pgpReader
                    TElPGPReader _pgpReader = new TElPGPReader()
                    {
                        KeyPassphrase = null,
                        OutputStream = streamOutput,
                        //assgin keyrings to reader
                        DecryptingKeys = Keyring,
                        VerifyingKeys = Keyring,
                    };
                    _pgpReader.OnKeyPassphrase += new SBPGPStreams.TSBPGPKeyPassphraseEvent(this.pgpReader_OnKeyPassphrase);
                    //pgpReader.Passphrase = PassPhrase; //setting PassPhrase here did not work.

                    _pgpReader.DecryptAndVerify(streamInput, 0);
                    bSuccess = true;
                }
                catch (Exception ex)
                {
                    Task asyncTask = WriteToLogFileAsync(string.Format("Sourcefile:{0} Error:{1}", sourceFile, ex.Message));
                    throw;
                }
                finally
                {
                    if (streamOutput != null)
                        streamOutput.Close();
                }
            }
            catch (Exception ex)
            {
                Task asyncTask = WriteToLogFileAsync(string.Format("Sourcefile:{0} Error:{1}", sourceFile, ex.Message));
                throw;
            }
            finally
            {
                if (streamInput != null)
                    streamInput.Close();
            }

            if (bSuccess)
            {
                new FileInfo(pgpFile).LastWriteTime = new FileInfo(sourceFile).LastWriteTime;
                new FileInfo(pgpFile).CreationTime = new FileInfo(sourceFile).CreationTime;
            }

            return bSuccess;
        }

        private void DirSearchAndEncrypt(string sDir)
        {
            List<Task> tasks = new List<Task>();

            try
            {
                if (Path.GetDirectoryName(sDir).StartsWith("EncrypterDecrypter", StringComparison.OrdinalIgnoreCase))
                    return;

                foreach (string f in Directory.EnumerateFiles(sDir)) //**
                {
                    Application.DoEvents();

                    Task t = Task.Run(() =>
                    {
                        if (!f.ToLower().EndsWith(".pgp") && new FileInfo(f).Length > 0)
                        {
                            if (Encrypt(f))
                            {
                                File.Delete(f);
                                _FileCount++;
                            }
                            else
                                _Errors++;
                        }
                    });

                    tasks.Add(t);

                    if (DateTime.Now > _Now)
                    {
                        RefreshMessage(false);
                    }
                }

                Task.WaitAll(tasks.ToArray());  //wait until all above tasks are complete
                
                foreach (string d in Directory.EnumerateDirectories(sDir))  //**
                {
                    DirSearchAndEncrypt(d);
                }
            }
            catch (System.Exception ex)
            {
                Task asyncTask = WriteToLogFileAsync(string.Format("RootDir:{0} Error:{1}", sDir, ex.Message));
                RefreshMessage(false);
                //LogError(excpt.Message);
            }
        }

        private void RefreshMessage(bool isDecrypt= true, bool lastMsg= false)
        {
            if (DateTime.Now > this._Now || lastMsg)
            {
                Application.DoEvents();

                this._Now = DateTime.Now.AddSeconds(RefreshInSeconds);
                if (isDecrypt)
                    this.lblStatus.Text = string.Format("Processing.. Files decrypted: {0} . Errors: {1}", this._FileCount, this._Errors);
                else
                    this.lblStatus.Text = string.Format("Processing.. Files encrypted: {0} . Errors: {1}", this._FileCount, this._Errors);

                this.lblStatus.ForeColor = isDecrypt ? Color.Green : Color.Purple;
                // Call Sleep so the picture is briefly displayed, 
                //which will create a slide-show effect.
                System.Threading.Thread.Sleep(10);
            }

        }

        private bool EncryptFolderSubFolders(string RootFolder)
        {
            try
            {
                DirSearchAndEncrypt(RootFolder);
            }
            finally
            {
                //_EncKeyring.Dispose();  //do this when different keys are used. assign new key before pgpwriter or pgpreader is used again 
            }

            RefreshMessage(false, true);
            return true;
        }

        #region "Private Methods"

        private bool Encrypt(string fileNamePath)
        {
            string pgpFile = fileNamePath + ".pgp";
            bool bSuccess = false;

            FileStream streamInput = null;
            try
            {
                streamInput = new FileStream(fileNamePath, FileMode.Open);
                FileStream streamOutput = new FileStream(pgpFile, FileMode.Create);
                try
                {
                    new TElPGPWriter()
                    {
                        Armor = false,
                        ArmorBoundary = null,
                        Compress = false,
                        //pgpWriter.CompressionLevel = 9;For ZLib the values are from 0 (no compression) to 9 (highest compression). 
                        EncryptionType = TSBPGPEncryptionType.etPublicKey,
                        InputIsText = false,
                        Protection = SBPGPConstants.TSBPGPProtectionType.ptNormal,
                        SignBufferingMethod = TSBPGPSignBufferingMethod.sbmRewind,
                        SigningKeys = null,
                        TextCompatibilityMode = true,
                        Timestamp = new System.DateTime(((long)(0))),
                        UseNewFeatures = true,
                        UseOldPackets = false,
                        EncryptingKeys = _EncKeyring,
                        CompressionAlgorithm = SBPGPConstants.Unit.SB_PGP_ALGORITHM_CM_UNCOMPRESSED, //refer help, if needed
                        Filename = Path.GetFileName(fileNamePath)
                    }.Encrypt(streamInput, streamOutput, 0);

                    bSuccess = true;
                }
                catch (Exception ex)
                {
                    Task asyncTask = WriteToLogFileAsync(string.Format("Sourcefile:{0} Error:{1}", fileNamePath, ex.Message));
                }
                finally
                {
                    streamOutput.Close();
                }
            }
            catch (Exception ex)
            {
                Task asyncTask = WriteToLogFileAsync(string.Format("Sourcefile:{0} Error:{1}", fileNamePath, ex.Message));
            }
            finally
            {
                if (streamInput != null)
                    streamInput.Close();
            }
            if (bSuccess)
            {
                new FileInfo(pgpFile).LastWriteTime = new FileInfo(fileNamePath).LastWriteTime;
                new FileInfo(pgpFile).CreationTime = new FileInfo(fileNamePath).CreationTime;
            }

            return bSuccess;
        }

        //Creates PublicKey based on key string
        private TElPGPPublicKey GetPublicKey(string KeyString)
        {
            MemoryStream stream = new MemoryStream();
            try
            {
                byte[] byteArray = Encoding.ASCII.GetBytes(KeyString);
                stream = new MemoryStream(byteArray);

                TElPGPPublicKey Publickey = new TElPGPPublicKey();

                Publickey.KeyHashAlgorithm = SBPGPConstants.Unit.SB_PGP_ALGORITHM_MD_AUTO;
                Publickey.LoadFromStream(stream);
                return Publickey;
            }
            catch (Exception ex)
            {
                Task asyncTask = WriteToLogFileAsync(string.Format("GetPublicKey Error:{0}", ex.Message));
                throw ex;
            }
            finally
            {
                stream.Close();
            }
        }

        //Creates PrivateKey based on key string
        private TElPGPSecretKey GetPrivateKey(string KeyString)
        {
            MemoryStream stream = new MemoryStream();
            try
            {
                byte[] byteArray = Encoding.ASCII.GetBytes(KeyString);
                stream = new MemoryStream(byteArray);

                TElPGPSecretKey PrivateKey = new TElPGPSecretKey();
                PrivateKey.KeyHashAlgorithm = SBPGPConstants.Unit.SB_PGP_ALGORITHM_MD_AUTO;
                PrivateKey.LoadFromStream(stream);
                return PrivateKey;
            }
            catch (Exception ex)
            {
                Task asyncTask = WriteToLogFileAsync(string.Format("GetPrivateKey Error:{0}", ex.Message));
                throw ex;
            }
            finally
            {
                stream.Close();
            }
        }

        //this delegate method must be present for Decryption, otherwise the logic would not work: UT
        private void pgpReader_OnKeyPassphrase(object Sender, TElPGPCustomSecretKey Key, ref string Passphrase, ref bool Cancel)
        {
            Passphrase = string.Empty;
        }

        #endregion

        private void btnDecryptSingleFile_Click(object sender, EventArgs e)
        {
            ClearValues();

            this.openFileDialog1.Filter = "pgp files|*.pgp";
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filenamePath = this.openFileDialog1.FileName;

                if (Path.GetExtension(filenamePath).ToLower().EndsWith(".pgp") && new FileInfo(filenamePath).Length > 0)
                {
                    if (Decrypt(filenamePath))
                    {
                        File.Delete(filenamePath);
                        MessageBox.Show("file has been decrypted");
                        label3.Text = "Decrypted file: " + filenamePath.Replace(".pgp", "");
                        label3.ForeColor = Color.Green;
                    }
                    else
                    {
                        label3.Text = "Failed to Decrypt file: " + filenamePath;
                    }
                }
                else
                {
                    label3.Text = "File already decrypted or zero byte";
                    label3.ForeColor = Color.Green;
                }
            }
        }

        private void btnEncryptSingleFile_Click(object sender, EventArgs e)
        {
            ClearValues();

            this.openFileDialog1.Filter = "All files|*.*";
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filenamePath = this.openFileDialog1.FileName;

                if (!filenamePath.ToLower().EndsWith(".pgp") && new FileInfo(filenamePath).Length > 0)
                {
                    if (Encrypt(filenamePath))
                    {
                        File.Delete(filenamePath);
                        MessageBox.Show("file has been Encrypted");
                        label3.Text = "Encrypted file: " + filenamePath + ".pgp";
                        label3.ForeColor = Color.Purple;
                    }
                    else
                    {
                        label3.Text = "Failed to Encrypt file: " + filenamePath;
                    }
                }
                else
                {
                    label3.Text = "File already encrypted or zero byte";
                    label3.ForeColor = Color.Purple;
                }
            }
        }

        private void ClearValues()
        {
            lblStatus.Text = "";
            label3.Text = "";
            label7.Text = "";
            this._FileCount = 0;
            _Errors = 0;
        }
        private void btnDecryptRootPlusSubFolders_Click(object sender, EventArgs e)
        {
            ClearValues();
            btnDecryptRootPlusSubFolders.Enabled = false;
            this.folderBrowserDialog1.SelectedPath =  Directory.Exists(@"C:\delete\1") ? @"C:\delete\1" : @"C:\"; // System.Environment.SpecialFolder.MyComputer;

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string foldername = this.folderBrowserDialog1.SelectedPath;
                if (MessageBox.Show("Do you really want to decrypt the files under this folder and it's subfolders?", "Verify", MessageBoxButtons.YesNo)
                     == DialogResult.Yes)
                {
                    MessageBox.Show("Notes: If a file is already decrypted, it will be ignored.", "Notes", MessageBoxButtons.OK);
                    DateTime started = DateTime.Now;
                    DecryptFolderSubFolders(foldername);
                    lblStatus.Text = lblStatus.Text + "            Done.. All Files have been decrypted.. Count: " + _FileCount.ToString() + " Took:" + (DateTime.Now - started).TotalSeconds.ToString();
                }
            }

            btnDecryptRootPlusSubFolders.Enabled = true;

        }
        //Encrypt all files from root and subfolders
        private void btnEncryptRootPlusSubFolders_Click(object sender, EventArgs e)
        {
            ClearValues();
            btnEncryptRootPlusSubFolders.Enabled = false;
            this.folderBrowserDialog1.SelectedPath = Directory.Exists(@"C:\delete\1") ? @"C:\delete\1" : @"C:\";  // System.Environment.SpecialFolder.MyComputer;;

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string foldername = this.folderBrowserDialog1.SelectedPath;
                if (MessageBox.Show("Do you really want to encrypt the files under this folder and it's subfolder?", "Verify", MessageBoxButtons.YesNo)
                     == DialogResult.Yes)
                {
                    MessageBox.Show("Notes: If file is already encrypted, it will not be encrypted again. It will be ignored.", "Notes", MessageBoxButtons.OK);
                    DateTime started = DateTime.Now;
                    EncryptFolderSubFolders(foldername);
                    lblStatus.Text = lblStatus.Text + "            Done.. All Files have been encrypted.. Count:" + _FileCount.ToString() + " Took:" + (DateTime.Now - started).TotalSeconds.ToString();
                }
            }

            btnEncryptRootPlusSubFolders.Enabled = true;

        }

        private async Task WriteToLogFileAsync(string MsgString)
        {
            try
            {
                using (StreamWriter ltwErrorLog = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EncrypterDecrypter.log"), true))
                {
                    await ltwErrorLog.WriteAsync(string.Format("{0:MM/dd/yyyy HH:mm:ss} {1}", DateTime.Now, MsgString));
                }
                 
                label7.Text = "See " + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EncrypterDecrypter.log");
            }
            catch { }
        }

    }
}
