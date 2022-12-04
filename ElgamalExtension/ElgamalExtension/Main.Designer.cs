namespace ElgamalExtension
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAutomatic = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblY = new System.Windows.Forms.Label();
            this.lblPrime = new System.Windows.Forms.Label();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.txtPublicY = new System.Windows.Forms.TextBox();
            this.txtPublicG = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.btnPrivateKey = new System.Windows.Forms.Button();
            this.txtPublicP = new System.Windows.Forms.TextBox();
            this.btnPublicP = new System.Windows.Forms.Button();
            this.lblDigest = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.txtMessageDigest = new System.Windows.Forms.TextBox();
            this.btnSignature = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.pnlManual = new System.Windows.Forms.Panel();
            this.lblMY = new System.Windows.Forms.Label();
            this.lblMG = new System.Windows.Forms.Label();
            this.lblMPrivateKey = new System.Windows.Forms.Label();
            this.txtMMessage = new System.Windows.Forms.TextBox();
            this.lblMPublicKey = new System.Windows.Forms.Label();
            this.btnMSign = new System.Windows.Forms.Button();
            this.txtPublicMY = new System.Windows.Forms.TextBox();
            this.txtPublicMG = new System.Windows.Forms.TextBox();
            this.txtMPrivateKey = new System.Windows.Forms.TextBox();
            this.lblMMessage = new System.Windows.Forms.Label();
            this.lblMMessageHash = new System.Windows.Forms.Label();
            this.txtPublicMP = new System.Windows.Forms.TextBox();
            this.txtMSignature = new System.Windows.Forms.TextBox();
            this.btnMSignatureCopy = new System.Windows.Forms.Button();
            this.txtMMessageHash = new System.Windows.Forms.TextBox();
            this.lblMSignature = new System.Windows.Forms.Label();
            this.btnMHashCopy = new System.Windows.Forms.Button();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlAutomatic.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlOutput.SuspendLayout();
            this.pnlManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAutomatic
            // 
            this.pnlAutomatic.Controls.Add(this.pnlInput);
            this.pnlAutomatic.Controls.Add(this.pnlOutput);
            this.pnlAutomatic.Location = new System.Drawing.Point(6, 75);
            this.pnlAutomatic.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAutomatic.Name = "pnlAutomatic";
            this.pnlAutomatic.Size = new System.Drawing.Size(810, 706);
            this.pnlAutomatic.TabIndex = 14;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblY);
            this.pnlInput.Controls.Add(this.lblPrime);
            this.pnlInput.Controls.Add(this.lblPrivateKey);
            this.pnlInput.Controls.Add(this.lblP);
            this.pnlInput.Controls.Add(this.txtPublicY);
            this.pnlInput.Controls.Add(this.txtPublicG);
            this.pnlInput.Controls.Add(this.txtPrivateKey);
            this.pnlInput.Controls.Add(this.btnPrivateKey);
            this.pnlInput.Controls.Add(this.txtPublicP);
            this.pnlInput.Controls.Add(this.btnPublicP);
            this.pnlInput.Controls.Add(this.lblDigest);
            this.pnlInput.Controls.Add(this.txtOutput);
            this.pnlInput.Controls.Add(this.lblSignature);
            this.pnlInput.Controls.Add(this.txtMessageDigest);
            this.pnlInput.Controls.Add(this.btnSignature);
            this.pnlInput.Controls.Add(this.btnCopy);
            this.pnlInput.Location = new System.Drawing.Point(4, 247);
            this.pnlInput.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(800, 433);
            this.pnlInput.TabIndex = 6;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(410, 293);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(117, 25);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Public Key (Y)";
            // 
            // lblPrime
            // 
            this.lblPrime.AutoSize = true;
            this.lblPrime.Location = new System.Drawing.Point(4, 293);
            this.lblPrime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrime.Name = "lblPrime";
            this.lblPrime.Size = new System.Drawing.Size(119, 25);
            this.lblPrime.TabIndex = 7;
            this.lblPrime.Text = "Public Key (G)";
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(4, 362);
            this.lblPrivateKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(124, 25);
            this.lblPrivateKey.TabIndex = 7;
            this.lblPrivateKey.Text = "Private Key (X)";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(4, 228);
            this.lblP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(117, 25);
            this.lblP.TabIndex = 7;
            this.lblP.Text = "Public Key (P)";
            // 
            // txtPublicY
            // 
            this.txtPublicY.BackColor = System.Drawing.Color.LightGray;
            this.txtPublicY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublicY.Location = new System.Drawing.Point(410, 320);
            this.txtPublicY.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublicY.Name = "txtPublicY";
            this.txtPublicY.ReadOnly = true;
            this.txtPublicY.Size = new System.Drawing.Size(383, 31);
            this.txtPublicY.TabIndex = 6;
            // 
            // txtPublicG
            // 
            this.txtPublicG.BackColor = System.Drawing.Color.LightGray;
            this.txtPublicG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublicG.Location = new System.Drawing.Point(6, 320);
            this.txtPublicG.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublicG.Name = "txtPublicG";
            this.txtPublicG.ReadOnly = true;
            this.txtPublicG.Size = new System.Drawing.Size(396, 31);
            this.txtPublicG.TabIndex = 6;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.BackColor = System.Drawing.Color.LightGray;
            this.txtPrivateKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrivateKey.Location = new System.Drawing.Point(6, 390);
            this.txtPrivateKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(662, 31);
            this.txtPrivateKey.TabIndex = 6;
            this.txtPrivateKey.UseSystemPasswordChar = true;
            // 
            // btnPrivateKey
            // 
            this.btnPrivateKey.Location = new System.Drawing.Point(674, 386);
            this.btnPrivateKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrivateKey.Name = "btnPrivateKey";
            this.btnPrivateKey.Size = new System.Drawing.Size(120, 40);
            this.btnPrivateKey.TabIndex = 5;
            this.btnPrivateKey.Text = "Show";
            this.btnPrivateKey.UseVisualStyleBackColor = true;
            // 
            // txtPublicP
            // 
            this.txtPublicP.BackColor = System.Drawing.Color.LightGray;
            this.txtPublicP.Location = new System.Drawing.Point(6, 256);
            this.txtPublicP.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublicP.Name = "txtPublicP";
            this.txtPublicP.ReadOnly = true;
            this.txtPublicP.Size = new System.Drawing.Size(662, 31);
            this.txtPublicP.TabIndex = 6;
            // 
            // btnPublicP
            // 
            this.btnPublicP.Location = new System.Drawing.Point(674, 252);
            this.btnPublicP.Margin = new System.Windows.Forms.Padding(4);
            this.btnPublicP.Name = "btnPublicP";
            this.btnPublicP.Size = new System.Drawing.Size(120, 40);
            this.btnPublicP.TabIndex = 5;
            this.btnPublicP.Text = "Copy";
            this.btnPublicP.UseVisualStyleBackColor = true;
            // 
            // lblDigest
            // 
            this.lblDigest.AutoSize = true;
            this.lblDigest.Location = new System.Drawing.Point(4, 0);
            this.lblDigest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDigest.Name = "lblDigest";
            this.lblDigest.Size = new System.Drawing.Size(138, 25);
            this.lblDigest.TabIndex = 4;
            this.lblDigest.Text = "Message Digest";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.LightGray;
            this.txtOutput.Location = new System.Drawing.Point(4, 91);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(664, 128);
            this.txtOutput.TabIndex = 0;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(4, 64);
            this.lblSignature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(143, 25);
            this.lblSignature.TabIndex = 1;
            this.lblSignature.Text = "Digital Signature";
            // 
            // txtMessageDigest
            // 
            this.txtMessageDigest.BackColor = System.Drawing.Color.LightGray;
            this.txtMessageDigest.Location = new System.Drawing.Point(6, 28);
            this.txtMessageDigest.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessageDigest.Name = "txtMessageDigest";
            this.txtMessageDigest.ReadOnly = true;
            this.txtMessageDigest.Size = new System.Drawing.Size(662, 31);
            this.txtMessageDigest.TabIndex = 3;
            // 
            // btnSignature
            // 
            this.btnSignature.Location = new System.Drawing.Point(674, 180);
            this.btnSignature.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignature.Name = "btnSignature";
            this.btnSignature.Size = new System.Drawing.Size(120, 40);
            this.btnSignature.TabIndex = 2;
            this.btnSignature.Text = "Copy";
            this.btnSignature.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(674, 24);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(120, 40);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // pnlOutput
            // 
            this.pnlOutput.Controls.Add(this.btnInfo);
            this.pnlOutput.Controls.Add(this.txtInput);
            this.pnlOutput.Controls.Add(this.lblMessage);
            this.pnlOutput.Controls.Add(this.btnSign);
            this.pnlOutput.Location = new System.Drawing.Point(0, 0);
            this.pnlOutput.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(804, 245);
            this.pnlOutput.TabIndex = 5;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(10, 201);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(208, 35);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Show Less";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Visible = false;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(4, 30);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(783, 137);
            this.txtInput.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(1, 2);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(82, 25);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(575, 178);
            this.btnSign.Margin = new System.Windows.Forms.Padding(4);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(212, 61);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            // 
            // pnlManual
            // 
            this.pnlManual.Controls.Add(this.lblMY);
            this.pnlManual.Controls.Add(this.lblMG);
            this.pnlManual.Controls.Add(this.lblMPrivateKey);
            this.pnlManual.Controls.Add(this.txtMMessage);
            this.pnlManual.Controls.Add(this.lblMPublicKey);
            this.pnlManual.Controls.Add(this.btnMSign);
            this.pnlManual.Controls.Add(this.txtPublicMY);
            this.pnlManual.Controls.Add(this.txtPublicMG);
            this.pnlManual.Controls.Add(this.txtMPrivateKey);
            this.pnlManual.Controls.Add(this.lblMMessage);
            this.pnlManual.Controls.Add(this.lblMMessageHash);
            this.pnlManual.Controls.Add(this.txtPublicMP);
            this.pnlManual.Controls.Add(this.txtMSignature);
            this.pnlManual.Controls.Add(this.btnMSignatureCopy);
            this.pnlManual.Controls.Add(this.txtMMessageHash);
            this.pnlManual.Controls.Add(this.lblMSignature);
            this.pnlManual.Controls.Add(this.btnMHashCopy);
            this.pnlManual.Location = new System.Drawing.Point(6, 75);
            this.pnlManual.Margin = new System.Windows.Forms.Padding(4);
            this.pnlManual.Name = "pnlManual";
            this.pnlManual.Size = new System.Drawing.Size(810, 706);
            this.pnlManual.TabIndex = 15;
            this.pnlManual.Visible = false;
            // 
            // lblMY
            // 
            this.lblMY.AutoSize = true;
            this.lblMY.Location = new System.Drawing.Point(397, 244);
            this.lblMY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMY.Name = "lblMY";
            this.lblMY.Size = new System.Drawing.Size(117, 25);
            this.lblMY.TabIndex = 7;
            this.lblMY.Text = "Public Key (Y)";
            // 
            // lblMG
            // 
            this.lblMG.AutoSize = true;
            this.lblMG.Location = new System.Drawing.Point(4, 244);
            this.lblMG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMG.Name = "lblMG";
            this.lblMG.Size = new System.Drawing.Size(119, 25);
            this.lblMG.TabIndex = 7;
            this.lblMG.Text = "Public Key (G)";
            // 
            // lblMPrivateKey
            // 
            this.lblMPrivateKey.AutoSize = true;
            this.lblMPrivateKey.Location = new System.Drawing.Point(4, 311);
            this.lblMPrivateKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMPrivateKey.Name = "lblMPrivateKey";
            this.lblMPrivateKey.Size = new System.Drawing.Size(124, 25);
            this.lblMPrivateKey.TabIndex = 7;
            this.lblMPrivateKey.Text = "Private Key (X)";
            // 
            // txtMMessage
            // 
            this.txtMMessage.Location = new System.Drawing.Point(4, 30);
            this.txtMMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMMessage.Multiline = true;
            this.txtMMessage.Name = "txtMMessage";
            this.txtMMessage.Size = new System.Drawing.Size(783, 137);
            this.txtMMessage.TabIndex = 0;
            // 
            // lblMPublicKey
            // 
            this.lblMPublicKey.AutoSize = true;
            this.lblMPublicKey.Location = new System.Drawing.Point(4, 175);
            this.lblMPublicKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMPublicKey.Name = "lblMPublicKey";
            this.lblMPublicKey.Size = new System.Drawing.Size(117, 25);
            this.lblMPublicKey.TabIndex = 7;
            this.lblMPublicKey.Text = "Public Key (P)";
            // 
            // btnMSign
            // 
            this.btnMSign.Location = new System.Drawing.Point(575, 378);
            this.btnMSign.Margin = new System.Windows.Forms.Padding(4);
            this.btnMSign.Name = "btnMSign";
            this.btnMSign.Size = new System.Drawing.Size(212, 61);
            this.btnMSign.TabIndex = 2;
            this.btnMSign.Text = "Sign";
            this.btnMSign.UseVisualStyleBackColor = true;
            // 
            // txtPublicMY
            // 
            this.txtPublicMY.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublicMY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublicMY.Location = new System.Drawing.Point(400, 271);
            this.txtPublicMY.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublicMY.Name = "txtPublicMY";
            this.txtPublicMY.Size = new System.Drawing.Size(386, 31);
            this.txtPublicMY.TabIndex = 6;
            // 
            // txtPublicMG
            // 
            this.txtPublicMG.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublicMG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublicMG.Location = new System.Drawing.Point(6, 271);
            this.txtPublicMG.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublicMG.Name = "txtPublicMG";
            this.txtPublicMG.Size = new System.Drawing.Size(386, 31);
            this.txtPublicMG.TabIndex = 6;
            // 
            // txtMPrivateKey
            // 
            this.txtMPrivateKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtMPrivateKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMPrivateKey.Location = new System.Drawing.Point(6, 338);
            this.txtMPrivateKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPrivateKey.Name = "txtMPrivateKey";
            this.txtMPrivateKey.Size = new System.Drawing.Size(780, 31);
            this.txtMPrivateKey.TabIndex = 6;
            // 
            // lblMMessage
            // 
            this.lblMMessage.AutoSize = true;
            this.lblMMessage.Location = new System.Drawing.Point(1, 2);
            this.lblMMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMMessage.Name = "lblMMessage";
            this.lblMMessage.Size = new System.Drawing.Size(82, 25);
            this.lblMMessage.TabIndex = 1;
            this.lblMMessage.Text = "Message";
            // 
            // lblMMessageHash
            // 
            this.lblMMessageHash.AutoSize = true;
            this.lblMMessageHash.Location = new System.Drawing.Point(4, 454);
            this.lblMMessageHash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMMessageHash.Name = "lblMMessageHash";
            this.lblMMessageHash.Size = new System.Drawing.Size(138, 25);
            this.lblMMessageHash.TabIndex = 4;
            this.lblMMessageHash.Text = "Message Digest";
            // 
            // txtPublicMP
            // 
            this.txtPublicMP.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublicMP.Location = new System.Drawing.Point(6, 203);
            this.txtPublicMP.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublicMP.Name = "txtPublicMP";
            this.txtPublicMP.Size = new System.Drawing.Size(780, 31);
            this.txtPublicMP.TabIndex = 6;
            // 
            // txtMSignature
            // 
            this.txtMSignature.BackColor = System.Drawing.Color.LightGray;
            this.txtMSignature.Location = new System.Drawing.Point(6, 545);
            this.txtMSignature.Margin = new System.Windows.Forms.Padding(4);
            this.txtMSignature.Multiline = true;
            this.txtMSignature.Name = "txtMSignature";
            this.txtMSignature.ReadOnly = true;
            this.txtMSignature.Size = new System.Drawing.Size(664, 128);
            this.txtMSignature.TabIndex = 0;
            // 
            // btnMSignatureCopy
            // 
            this.btnMSignatureCopy.Location = new System.Drawing.Point(677, 634);
            this.btnMSignatureCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnMSignatureCopy.Name = "btnMSignatureCopy";
            this.btnMSignatureCopy.Size = new System.Drawing.Size(120, 40);
            this.btnMSignatureCopy.TabIndex = 2;
            this.btnMSignatureCopy.Text = "Copy";
            this.btnMSignatureCopy.UseVisualStyleBackColor = true;
            // 
            // txtMMessageHash
            // 
            this.txtMMessageHash.BackColor = System.Drawing.Color.LightGray;
            this.txtMMessageHash.Location = new System.Drawing.Point(6, 481);
            this.txtMMessageHash.Margin = new System.Windows.Forms.Padding(4);
            this.txtMMessageHash.Name = "txtMMessageHash";
            this.txtMMessageHash.ReadOnly = true;
            this.txtMMessageHash.Size = new System.Drawing.Size(662, 31);
            this.txtMMessageHash.TabIndex = 3;
            // 
            // lblMSignature
            // 
            this.lblMSignature.AutoSize = true;
            this.lblMSignature.Location = new System.Drawing.Point(6, 517);
            this.lblMSignature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSignature.Name = "lblMSignature";
            this.lblMSignature.Size = new System.Drawing.Size(143, 25);
            this.lblMSignature.TabIndex = 1;
            this.lblMSignature.Text = "Digital Signature";
            // 
            // btnMHashCopy
            // 
            this.btnMHashCopy.Location = new System.Drawing.Point(674, 478);
            this.btnMHashCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnMHashCopy.Name = "btnMHashCopy";
            this.btnMHashCopy.Size = new System.Drawing.Size(120, 40);
            this.btnMHashCopy.TabIndex = 2;
            this.btnMHashCopy.Text = "Copy";
            this.btnMHashCopy.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(163, 39);
            this.rbManual.Margin = new System.Windows.Forms.Padding(4);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(95, 29);
            this.rbManual.TabIndex = 13;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Checked = true;
            this.rbAuto.Location = new System.Drawing.Point(16, 39);
            this.rbAuto.Margin = new System.Windows.Forms.Padding(4);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(119, 29);
            this.rbAuto.TabIndex = 12;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automatic";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 12);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(59, 25);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Mode";
            // 
            // ElgamalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 321);
            this.Controls.Add(this.pnlAutomatic);
            this.Controls.Add(this.pnlManual);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.rbAuto);
            this.Controls.Add(this.lblType);
            this.Name = "ElgamalForm";
            this.Text = "Elgamal";
            this.pnlAutomatic.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            this.pnlManual.ResumeLayout(false);
            this.pnlManual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlAutomatic;
        private Panel pnlInput;
        private Label lblY;
        private Label lblPrime;
        private Label lblPrivateKey;
        private Label lblP;
        private TextBox txtPublicY;
        private TextBox txtPublicG;
        private TextBox txtPrivateKey;
        private Button btnPrivateKey;
        private TextBox txtPublicP;
        private Button btnPublicP;
        private Label lblDigest;
        private TextBox txtOutput;
        private Label lblSignature;
        private TextBox txtMessageDigest;
        private Button btnSignature;
        private Button btnCopy;
        private Panel pnlOutput;
        private Button btnInfo;
        private TextBox txtInput;
        private Label lblMessage;
        private Button btnSign;
        private Panel pnlManual;
        private Label lblMY;
        private Label lblMG;
        private Label lblMPrivateKey;
        private TextBox txtMMessage;
        private Label lblMPublicKey;
        private Button btnMSign;
        private TextBox txtPublicMY;
        private TextBox txtPublicMG;
        private TextBox txtMPrivateKey;
        private Label lblMMessage;
        private Label lblMMessageHash;
        private TextBox txtPublicMP;
        private TextBox txtMSignature;
        private Button btnMSignatureCopy;
        private TextBox txtMMessageHash;
        private Label lblMSignature;
        private Button btnMHashCopy;
        private RadioButton rbManual;
        private RadioButton rbAuto;
        private Label lblType;
    }
}