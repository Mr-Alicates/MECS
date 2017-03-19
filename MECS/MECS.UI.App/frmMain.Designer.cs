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
            this.GrpMovement = new System.Windows.Forms.GroupBox();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnMoveRight = new System.Windows.Forms.Button();
            this.BtnMoveDown = new System.Windows.Forms.Button();
            this.BtnMoveToCenter = new System.Windows.Forms.Button();
            this.BtnMoveLeft = new System.Windows.Forms.Button();
            this.BtnMoveUp = new System.Windows.Forms.Button();
            this.BtnMoveToOrigin = new System.Windows.Forms.Button();
            this.NumBurningTime = new System.Windows.Forms.NumericUpDown();
            this.BtnSetBurningTime = new System.Windows.Forms.Button();
            this.GrpBurningTime = new System.Windows.Forms.GroupBox();
            this.GrpConnection.SuspendLayout();
            this.GrpMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBurningTime)).BeginInit();
            this.GrpBurningTime.SuspendLayout();
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
            // GrpMovement
            // 
            this.GrpMovement.Controls.Add(this.BtnPreview);
            this.GrpMovement.Controls.Add(this.BtnMoveRight);
            this.GrpMovement.Controls.Add(this.BtnMoveDown);
            this.GrpMovement.Controls.Add(this.BtnMoveToCenter);
            this.GrpMovement.Controls.Add(this.BtnMoveLeft);
            this.GrpMovement.Controls.Add(this.BtnMoveUp);
            this.GrpMovement.Controls.Add(this.BtnMoveToOrigin);
            this.GrpMovement.Enabled = false;
            this.GrpMovement.Location = new System.Drawing.Point(18, 152);
            this.GrpMovement.Name = "GrpMovement";
            this.GrpMovement.Size = new System.Drawing.Size(221, 195);
            this.GrpMovement.TabIndex = 0;
            this.GrpMovement.TabStop = false;
            this.GrpMovement.Text = "Movement controls";
            // 
            // BtnPreview
            // 
            this.BtnPreview.Location = new System.Drawing.Point(150, 19);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(65, 51);
            this.BtnPreview.TabIndex = 0;
            this.BtnPreview.Text = "Preview carving area";
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.Preview);
            // 
            // BtnMoveRight
            // 
            this.BtnMoveRight.Location = new System.Drawing.Point(148, 133);
            this.BtnMoveRight.Name = "BtnMoveRight";
            this.BtnMoveRight.Size = new System.Drawing.Size(65, 51);
            this.BtnMoveRight.TabIndex = 0;
            this.BtnMoveRight.Text = "Move Right";
            this.BtnMoveRight.UseVisualStyleBackColor = true;
            this.BtnMoveRight.Click += new System.EventHandler(this.MoveRight);
            // 
            // BtnMoveDown
            // 
            this.BtnMoveDown.Location = new System.Drawing.Point(77, 133);
            this.BtnMoveDown.Name = "BtnMoveDown";
            this.BtnMoveDown.Size = new System.Drawing.Size(65, 51);
            this.BtnMoveDown.TabIndex = 0;
            this.BtnMoveDown.Text = "Move Down";
            this.BtnMoveDown.UseVisualStyleBackColor = true;
            this.BtnMoveDown.Click += new System.EventHandler(this.MoveDown);
            // 
            // BtnMoveToCenter
            // 
            this.BtnMoveToCenter.Location = new System.Drawing.Point(77, 19);
            this.BtnMoveToCenter.Name = "BtnMoveToCenter";
            this.BtnMoveToCenter.Size = new System.Drawing.Size(65, 51);
            this.BtnMoveToCenter.TabIndex = 0;
            this.BtnMoveToCenter.Text = "Move To Center";
            this.BtnMoveToCenter.UseVisualStyleBackColor = true;
            this.BtnMoveToCenter.Click += new System.EventHandler(this.MoveToCenter);
            // 
            // BtnMoveLeft
            // 
            this.BtnMoveLeft.Location = new System.Drawing.Point(6, 133);
            this.BtnMoveLeft.Name = "BtnMoveLeft";
            this.BtnMoveLeft.Size = new System.Drawing.Size(65, 51);
            this.BtnMoveLeft.TabIndex = 0;
            this.BtnMoveLeft.Text = "Move Left";
            this.BtnMoveLeft.UseVisualStyleBackColor = true;
            this.BtnMoveLeft.Click += new System.EventHandler(this.MoveLeft);
            // 
            // BtnMoveUp
            // 
            this.BtnMoveUp.Location = new System.Drawing.Point(77, 76);
            this.BtnMoveUp.Name = "BtnMoveUp";
            this.BtnMoveUp.Size = new System.Drawing.Size(65, 51);
            this.BtnMoveUp.TabIndex = 0;
            this.BtnMoveUp.Text = "Move Up";
            this.BtnMoveUp.UseVisualStyleBackColor = true;
            this.BtnMoveUp.Click += new System.EventHandler(this.MoveUp);
            // 
            // BtnMoveToOrigin
            // 
            this.BtnMoveToOrigin.Location = new System.Drawing.Point(6, 19);
            this.BtnMoveToOrigin.Name = "BtnMoveToOrigin";
            this.BtnMoveToOrigin.Size = new System.Drawing.Size(65, 51);
            this.BtnMoveToOrigin.TabIndex = 0;
            this.BtnMoveToOrigin.Text = "Move to Origin";
            this.BtnMoveToOrigin.UseVisualStyleBackColor = true;
            this.BtnMoveToOrigin.Click += new System.EventHandler(this.MoveToOrigin);
            // 
            // NumBurningTime
            // 
            this.NumBurningTime.Location = new System.Drawing.Point(6, 36);
            this.NumBurningTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumBurningTime.Name = "NumBurningTime";
            this.NumBurningTime.Size = new System.Drawing.Size(136, 20);
            this.NumBurningTime.TabIndex = 0;
            this.NumBurningTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnSetBurningTime
            // 
            this.BtnSetBurningTime.Location = new System.Drawing.Point(148, 19);
            this.BtnSetBurningTime.Name = "BtnSetBurningTime";
            this.BtnSetBurningTime.Size = new System.Drawing.Size(65, 51);
            this.BtnSetBurningTime.TabIndex = 1;
            this.BtnSetBurningTime.Text = "Set burning time";
            this.BtnSetBurningTime.UseVisualStyleBackColor = true;
            this.BtnSetBurningTime.Click += new System.EventHandler(this.SetBurningTime);
            // 
            // GrpBurningTime
            // 
            this.GrpBurningTime.Controls.Add(this.BtnSetBurningTime);
            this.GrpBurningTime.Controls.Add(this.NumBurningTime);
            this.GrpBurningTime.Enabled = false;
            this.GrpBurningTime.Location = new System.Drawing.Point(18, 353);
            this.GrpBurningTime.Name = "GrpBurningTime";
            this.GrpBurningTime.Size = new System.Drawing.Size(221, 79);
            this.GrpBurningTime.TabIndex = 1;
            this.GrpBurningTime.TabStop = false;
            this.GrpBurningTime.Text = "Burning time controls";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 629);
            this.Controls.Add(this.GrpBurningTime);
            this.Controls.Add(this.GrpMovement);
            this.Controls.Add(this.GrpConnection);
            this.Name = "FrmMain";
            this.Text = "MECS: Mini Engraving Machine Software";
            this.Load += new System.EventHandler(this.FormLoad);
            this.GrpConnection.ResumeLayout(false);
            this.GrpMovement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumBurningTime)).EndInit();
            this.GrpBurningTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpConnection;
        private System.Windows.Forms.ComboBox CmbAvailablePorts;
        private System.Windows.Forms.ComboBox CmbAvailableDrivers;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.GroupBox GrpMovement;
        private System.Windows.Forms.Button BtnMoveRight;
        private System.Windows.Forms.Button BtnMoveToCenter;
        private System.Windows.Forms.Button BtnMoveLeft;
        private System.Windows.Forms.Button BtnMoveUp;
        private System.Windows.Forms.Button BtnMoveToOrigin;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Button BtnMoveDown;
        private System.Windows.Forms.NumericUpDown NumBurningTime;
        private System.Windows.Forms.Button BtnSetBurningTime;
        private System.Windows.Forms.GroupBox GrpBurningTime;
    }
}

