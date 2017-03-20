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
            this.GrpEngravingControls = new System.Windows.Forms.GroupBox();
            this.BtnLoadPicture = new System.Windows.Forms.Button();
            this.BtnEngrave = new System.Windows.Forms.Button();
            this.BtnEraseMachineMemory = new System.Windows.Forms.Button();
            this.GrpPicture = new System.Windows.Forms.GroupBox();
            this.PbxOriginal = new System.Windows.Forms.PictureBox();
            this.PbxToEngrave = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkStretchToSize = new System.Windows.Forms.CheckBox();
            this.ChkKeepAspectRatio = new System.Windows.Forms.CheckBox();
            this.GrpConnection.SuspendLayout();
            this.GrpMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBurningTime)).BeginInit();
            this.GrpBurningTime.SuspendLayout();
            this.GrpEngravingControls.SuspendLayout();
            this.GrpPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxToEngrave)).BeginInit();
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
            this.GrpConnection.Size = new System.Drawing.Size(220, 134);
            this.GrpConnection.TabIndex = 0;
            this.GrpConnection.TabStop = false;
            this.GrpConnection.Text = "Machine connection";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(6, 102);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(207, 23);
            this.BtnDisconnect.TabIndex = 1;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.DisconnectEngraver);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(6, 73);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(207, 23);
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
            this.CmbAvailablePorts.Size = new System.Drawing.Size(207, 21);
            this.CmbAvailablePorts.TabIndex = 2;
            this.CmbAvailablePorts.Text = "Select a port...";
            // 
            // CmbAvailableDrivers
            // 
            this.CmbAvailableDrivers.FormattingEnabled = true;
            this.CmbAvailableDrivers.Location = new System.Drawing.Point(6, 19);
            this.CmbAvailableDrivers.Name = "CmbAvailableDrivers";
            this.CmbAvailableDrivers.Size = new System.Drawing.Size(207, 21);
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
            this.GrpMovement.Location = new System.Drawing.Point(12, 152);
            this.GrpMovement.Name = "GrpMovement";
            this.GrpMovement.Size = new System.Drawing.Size(220, 195);
            this.GrpMovement.TabIndex = 0;
            this.GrpMovement.TabStop = false;
            this.GrpMovement.Text = "Movement controls";
            // 
            // BtnPreview
            // 
            this.BtnPreview.Location = new System.Drawing.Point(148, 19);
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
            this.GrpBurningTime.Location = new System.Drawing.Point(12, 353);
            this.GrpBurningTime.Name = "GrpBurningTime";
            this.GrpBurningTime.Size = new System.Drawing.Size(220, 79);
            this.GrpBurningTime.TabIndex = 1;
            this.GrpBurningTime.TabStop = false;
            this.GrpBurningTime.Text = "Burning time controls";
            // 
            // GrpEngravingControls
            // 
            this.GrpEngravingControls.Controls.Add(this.BtnLoadPicture);
            this.GrpEngravingControls.Controls.Add(this.BtnEngrave);
            this.GrpEngravingControls.Controls.Add(this.BtnEraseMachineMemory);
            this.GrpEngravingControls.Enabled = false;
            this.GrpEngravingControls.Location = new System.Drawing.Point(12, 438);
            this.GrpEngravingControls.Name = "GrpEngravingControls";
            this.GrpEngravingControls.Size = new System.Drawing.Size(220, 101);
            this.GrpEngravingControls.TabIndex = 3;
            this.GrpEngravingControls.TabStop = false;
            this.GrpEngravingControls.Text = "Engraving controls";
            // 
            // BtnLoadPicture
            // 
            this.BtnLoadPicture.Location = new System.Drawing.Point(6, 19);
            this.BtnLoadPicture.Name = "BtnLoadPicture";
            this.BtnLoadPicture.Size = new System.Drawing.Size(207, 23);
            this.BtnLoadPicture.TabIndex = 3;
            this.BtnLoadPicture.Text = "Load picture";
            this.BtnLoadPicture.UseVisualStyleBackColor = true;
            this.BtnLoadPicture.Click += new System.EventHandler(this.LoadPicture);
            // 
            // BtnEngrave
            // 
            this.BtnEngrave.Enabled = false;
            this.BtnEngrave.Location = new System.Drawing.Point(115, 48);
            this.BtnEngrave.Name = "BtnEngrave";
            this.BtnEngrave.Size = new System.Drawing.Size(98, 45);
            this.BtnEngrave.TabIndex = 1;
            this.BtnEngrave.Text = "Engrave";
            this.BtnEngrave.UseVisualStyleBackColor = true;
            this.BtnEngrave.Click += new System.EventHandler(this.EngravePicture);
            // 
            // BtnEraseMachineMemory
            // 
            this.BtnEraseMachineMemory.Location = new System.Drawing.Point(6, 48);
            this.BtnEraseMachineMemory.Name = "BtnEraseMachineMemory";
            this.BtnEraseMachineMemory.Size = new System.Drawing.Size(94, 45);
            this.BtnEraseMachineMemory.TabIndex = 1;
            this.BtnEraseMachineMemory.Text = "Erase machine memory";
            this.BtnEraseMachineMemory.UseVisualStyleBackColor = true;
            this.BtnEraseMachineMemory.Click += new System.EventHandler(this.EraseMachineMemory);
            // 
            // GrpPicture
            // 
            this.GrpPicture.Controls.Add(this.ChkKeepAspectRatio);
            this.GrpPicture.Controls.Add(this.ChkStretchToSize);
            this.GrpPicture.Controls.Add(this.label2);
            this.GrpPicture.Controls.Add(this.label1);
            this.GrpPicture.Controls.Add(this.PbxToEngrave);
            this.GrpPicture.Controls.Add(this.PbxOriginal);
            this.GrpPicture.Enabled = false;
            this.GrpPicture.Location = new System.Drawing.Point(238, 12);
            this.GrpPicture.Name = "GrpPicture";
            this.GrpPicture.Size = new System.Drawing.Size(1189, 538);
            this.GrpPicture.TabIndex = 4;
            this.GrpPicture.TabStop = false;
            this.GrpPicture.Text = "Picture to engrave";
            // 
            // PbxOriginal
            // 
            this.PbxOriginal.Location = new System.Drawing.Point(6, 32);
            this.PbxOriginal.MaximumSize = new System.Drawing.Size(500, 500);
            this.PbxOriginal.MinimumSize = new System.Drawing.Size(500, 500);
            this.PbxOriginal.Name = "PbxOriginal";
            this.PbxOriginal.Size = new System.Drawing.Size(500, 500);
            this.PbxOriginal.TabIndex = 0;
            this.PbxOriginal.TabStop = false;
            // 
            // PbxToEngrave
            // 
            this.PbxToEngrave.Location = new System.Drawing.Point(512, 32);
            this.PbxToEngrave.MaximumSize = new System.Drawing.Size(500, 500);
            this.PbxToEngrave.MinimumSize = new System.Drawing.Size(500, 500);
            this.PbxToEngrave.Name = "PbxToEngrave";
            this.PbxToEngrave.Size = new System.Drawing.Size(500, 500);
            this.PbxToEngrave.TabIndex = 1;
            this.PbxToEngrave.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Picture to engrave";
            // 
            // ChkStretchToSize
            // 
            this.ChkStretchToSize.AutoSize = true;
            this.ChkStretchToSize.Location = new System.Drawing.Point(1018, 19);
            this.ChkStretchToSize.Name = "ChkStretchToSize";
            this.ChkStretchToSize.Size = new System.Drawing.Size(150, 17);
            this.ChkStretchToSize.TabIndex = 3;
            this.ChkStretchToSize.Text = "Scale picture to 500 x 500";
            this.ChkStretchToSize.UseVisualStyleBackColor = true;
            this.ChkStretchToSize.CheckStateChanged += new System.EventHandler(this.RecalulatePictureBoxes);
            // 
            // ChkKeepAspectRatio
            // 
            this.ChkKeepAspectRatio.AutoSize = true;
            this.ChkKeepAspectRatio.Location = new System.Drawing.Point(1018, 42);
            this.ChkKeepAspectRatio.Name = "ChkKeepAspectRatio";
            this.ChkKeepAspectRatio.Size = new System.Drawing.Size(109, 17);
            this.ChkKeepAspectRatio.TabIndex = 3;
            this.ChkKeepAspectRatio.Text = "Keep aspect ratio";
            this.ChkKeepAspectRatio.UseVisualStyleBackColor = true;
            this.ChkKeepAspectRatio.CheckStateChanged += new System.EventHandler(this.RecalulatePictureBoxes);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 635);
            this.Controls.Add(this.GrpPicture);
            this.Controls.Add(this.GrpEngravingControls);
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
            this.GrpEngravingControls.ResumeLayout(false);
            this.GrpPicture.ResumeLayout(false);
            this.GrpPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxToEngrave)).EndInit();
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
        private System.Windows.Forms.GroupBox GrpEngravingControls;
        private System.Windows.Forms.Button BtnEngrave;
        private System.Windows.Forms.Button BtnEraseMachineMemory;
        private System.Windows.Forms.Button BtnLoadPicture;
        private System.Windows.Forms.GroupBox GrpPicture;
        private System.Windows.Forms.PictureBox PbxOriginal;
        private System.Windows.Forms.PictureBox PbxToEngrave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkKeepAspectRatio;
        private System.Windows.Forms.CheckBox ChkStretchToSize;
    }
}

