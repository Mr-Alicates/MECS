namespace MECS.UI.App
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrpConnection = new System.Windows.Forms.GroupBox();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.CmbAvailablePorts = new System.Windows.Forms.ComboBox();
            this.CmbAvailableDrivers = new System.Windows.Forms.ComboBox();
            this.GrpConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpConnection
            // 
            this.GrpConnection.Controls.Add(this.BtnDisconnect);
            this.GrpConnection.Controls.Add(this.BtnConnect);
            this.GrpConnection.Controls.Add(this.CmbAvailablePorts);
            this.GrpConnection.Controls.Add(this.CmbAvailableDrivers);
            this.GrpConnection.Location = new System.Drawing.Point(12, 12);
            this.GrpConnection.Name = "GrpConnection";
            this.GrpConnection.Size = new System.Drawing.Size(233, 134);
            this.GrpConnection.TabIndex = 0;
            this.GrpConnection.TabStop = false;
            this.GrpConnection.Text = "Machine connection";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(6, 102);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(221, 23);
            this.BtnDisconnect.TabIndex = 1;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.DisconnectEngraver);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(6, 73);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(221, 23);
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.ConnectToEngraver);
            // 
            // CmbAvailablePorts
            // 
            this.CmbAvailablePorts.FormattingEnabled = true;
            this.CmbAvailablePorts.Location = new System.Drawing.Point(6, 46);
            this.CmbAvailablePorts.Name = "CmbAvailablePorts";
            this.CmbAvailablePorts.Size = new System.Drawing.Size(221, 21);
            this.CmbAvailablePorts.TabIndex = 2;
            this.CmbAvailablePorts.Text = "Select a port...";
            // 
            // CmbAvailableDrivers
            // 
            this.CmbAvailableDrivers.FormattingEnabled = true;
            this.CmbAvailableDrivers.Location = new System.Drawing.Point(6, 19);
            this.CmbAvailableDrivers.Name = "CmbAvailableDrivers";
            this.CmbAvailableDrivers.Size = new System.Drawing.Size(221, 21);
            this.CmbAvailableDrivers.TabIndex = 1;
            this.CmbAvailableDrivers.Text = "Select a driver...";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 625);
            this.Controls.Add(this.GrpConnection);
            this.Name = "FrmMain";
            this.Text = "MECS: Mini Engraving Machine Software";
            this.Load += new System.EventHandler(this.FormLoad);
            this.GrpConnection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpConnection;
        private System.Windows.Forms.ComboBox CmbAvailablePorts;
        private System.Windows.Forms.ComboBox CmbAvailableDrivers;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Button BtnConnect;
    }
}

