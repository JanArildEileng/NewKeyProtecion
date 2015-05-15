using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace Fhi.Felles.KeyProtection
{
    public partial class Protect : Form
    {
        public Protect()
        {
            InitializeComponent();
        }

        #region Rijndael
        private void Protect_Load(object sender, EventArgs e)
        {
            lblStringCurrentCredentials.Text =  lblCurrentCredentials.Text = WindowsIdentity.GetCurrent().Name;
            
        }

        private void btnGenerateRijndael_Click(object sender, EventArgs e)
        {
            using (var rm = new RijndaelManaged())
            {
                rm.GenerateKey();
                txtKeyBase64Source.Text = Convert.ToBase64String(rm.Key);

                rm.GenerateIV();
                txtIVBase64Source.Text = Convert.ToBase64String(rm.IV);
            }
        }

        private void btnProtectRijndael_Click(object sender, EventArgs e)
        {
            if (ValidateMyProtectRijndaelTab())
            {
                var key = new RijndaelManagedContainer(Convert.FromBase64String(txtKeyBase64Source.Text),
                                                       Convert.FromBase64String(txtIVBase64Source.Text));

                var request = new RijndaelProtectRequest(key, txtWriteKeypath.Text, txtWriteIVPath.Text);

                ProtectResponse response = ProtectRijndael(request);

                txtExecutionLog.Text += response.Log;
                lblCurrentCredentials.Text = WindowsIdentity.GetCurrent().Name;

            }
        }

        private ProtectResponse ProtectRijndael(RijndaelProtectRequest request)
        {
            var log = new StringBuilder();
            File.WriteAllBytes(request.ProtectedKeyPath, DataProtection.ProtectForUser(request.RijndaelManagedContainer.Key));
            log.AppendLine("Protected key at " + request.ProtectedKeyPath);

            File.WriteAllBytes(request.ProtectedIVPath, DataProtection.ProtectForUser(request.RijndaelManagedContainer.Vector));
            log.AppendLine("Protected vector at " + request.ProtectedIVPath);

            return new ProtectResponse(log.ToString());
        }
        
        private bool ValidateMyProtectRijndaelTab()
        {
            var sb = new StringBuilder();
            if (string.IsNullOrEmpty(txtKeyBase64Source.Text))
                sb.AppendLine("Load, paste or generate key");
            if (string.IsNullOrEmpty(txtIVBase64Source.Text))
                sb.AppendLine("Load, paste or generate IV");

            if (sb.Length == 0)
            {
                return true;
            }

            ShowValidation(sb.ToString());
            return false;
        }

        private void btnLoadRijndael_Click(object sender, EventArgs e)
        {
            var keyBytes = File.ReadAllBytes(txtKeyFilePathSource.Text);
            var IVbytes = File.ReadAllBytes(txtIVFilePathSource.Text);

            txtKeyBase64Source.Text = Convert.ToBase64String(keyBytes);
            txtIVBase64Source.Text = Convert.ToBase64String(IVbytes);
        }
        #endregion


        #region ShowValidation
        private void ShowValidation(string message)
        {
            MessageBox.Show(message);
        }
        #endregion

        #region ProtectString

        private bool ValidateMyProtectStringTab()
        {
            var sb = new StringBuilder();
            if (string.IsNullOrEmpty(txtUnprotectedString.Text))
                sb.AppendLine("Type or paste string to protect");
            if (string.IsNullOrEmpty(txtProtectedStringPath.Text))
                sb.AppendLine("Type or paste path to protect string to");

            if (sb.Length == 0)
            {
                return true;
            }

            ShowValidation(sb.ToString());
            return false;
        }

        private void btnProtectString_Click(object sender, EventArgs e)
        {
            if (ValidateMyProtectStringTab())
            {
                var response = ProtectString(new StringProtectRequest(txtUnprotectedString.Text, txtProtectedStringPath.Text));

                txtExecutionLog.Text += response.Log;
                lblStringCurrentCredentials.Text = WindowsIdentity.GetCurrent().Name;
            }
        }
        
        private ProtectResponse ProtectString(StringProtectRequest request)
        {
            var log = new StringBuilder();
            File.WriteAllBytes(request.ProtectedStringPath, DataProtection.ProtectForUser(System.Text.Encoding.UTF8.GetBytes(request.UnprotectedString)));
            log.AppendLine("Protected string at " + request.ProtectedStringPath);

            return new ProtectResponse(log.ToString());
        }
        
        #endregion

        private void btnLoadProtected_Click(object sender, EventArgs e)
        {
            
            var keyBytes = File.ReadAllBytes(txtProtectedKeyFilePathSource.Text);
            var IVbytes = File.ReadAllBytes(txtProtectedIVFilePathSource.Text);

            var unprotectedKey = ProtectedData.Unprotect(keyBytes, null, DataProtectionScope.CurrentUser);
            var unprotectedIV = ProtectedData.Unprotect(IVbytes, null, DataProtectionScope.CurrentUser);

            txtKeyBase64Source.Text = Convert.ToBase64String(unprotectedKey);
            txtIVBase64Source.Text = Convert.ToBase64String(unprotectedIV);
        }
    }
}
