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
            this.btnStop = new System.Windows.Forms.Button();
            this.BtnLoadPicture = new System.Windows.Forms.Button();
            this.BtnEngrave = new System.Windows.Forms.Button();
            this.btnSendImageToMachine = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.GrpPicture = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PbxToEngrave = new System.Windows.Forms.PictureBox();
            this.PbxOriginal = new System.Windows.Forms.PictureBox();
            this.ChkKeepAspectRatio = new System.Windows.Forms.CheckBox();
            this.ChkStretchToSize = new System.Windows.Forms.CheckBox();
            this.grpPictureManipulation = new System.Windows.Forms.GroupBox();
            this.grpMachineStatus = new System.Windows.Forms.GroupBox();
            this.prgEngravingProgress = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYPosition = new System.Windows.Forms.TextBox();
            this.txtXPosition = new System.Windows.Forms.TextBox();
            this.txtMachineStatus = new System.Windows.Forms.TextBox();
            this.GrpConnection.SuspendLayout();
            this.GrpMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBurningTime)).BeginInit();
            this.GrpBurningTime.SuspendLayout();
            this.GrpEngravingControls.SuspendLayout();
            this.GrpPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxToEngrave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOriginal)).BeginInit();
            this.grpPictureManipulation.SuspendLayout();
            this.grpMachineStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpConnection
            // 
            this.GrpConnection.Controls.Add(this.BtnDisconnect);
            this.GrpConnection.Controls.Add(this.BtnConnect);
            this.GrpConnection.Controls.Add(this.CmbAvailablePorts);
            this.GrpConnection.Controls.Add(this.CmbAvailableDrivers);
            this.GrpConnection.Location = new System.Drawing.Point(14, 14);
            this.GrpConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpConnection.Name = "GrpConnection";
            this.GrpConnection.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpConnection.Size = new System.Drawing.Size(257, 155);
            this.GrpConnection.TabIndex = 0;
            this.GrpConnection.TabStop = false;
            this.GrpConnection.Text = "Machine connection";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(7, 118);
            this.BtnDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(241, 27);
            this.BtnDisconnect.TabIndex = 1;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.DisconnectEngraver);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(7, 84);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(241, 27);
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.ConnectToEngraver);
            // 
            // CmbAvailablePorts
            // 
            this.CmbAvailablePorts.FormattingEnabled = true;
            this.CmbAvailablePorts.Location = new System.Drawing.Point(7, 53);
            this.CmbAvailablePorts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbAvailablePorts.Name = "CmbAvailablePorts";
            this.CmbAvailablePorts.Size = new System.Drawing.Size(241, 23);
            this.CmbAvailablePorts.TabIndex = 2;
            this.CmbAvailablePorts.Text = "Select a port...";
            // 
            // CmbAvailableDrivers
            // 
            this.CmbAvailableDrivers.FormattingEnabled = true;
            this.CmbAvailableDrivers.Location = new System.Drawing.Point(7, 22);
            this.CmbAvailableDrivers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbAvailableDrivers.Name = "CmbAvailableDrivers";
            this.CmbAvailableDrivers.Size = new System.Drawing.Size(241, 23);
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
            this.GrpMovement.Location = new System.Drawing.Point(14, 175);
            this.GrpMovement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpMovement.Name = "GrpMovement";
            this.GrpMovement.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpMovement.Size = new System.Drawing.Size(257, 225);
            this.GrpMovement.TabIndex = 0;
            this.GrpMovement.TabStop = false;
            this.GrpMovement.Text = "Movement controls";
            // 
            // BtnPreview
            // 
            this.BtnPreview.Location = new System.Drawing.Point(173, 22);
            this.BtnPreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(76, 59);
            this.BtnPreview.TabIndex = 0;
            this.BtnPreview.Text = "Preview carving area";
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.Preview);
            // 
            // BtnMoveRight
            // 
            this.BtnMoveRight.Location = new System.Drawing.Point(173, 153);
            this.BtnMoveRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMoveRight.Name = "BtnMoveRight";
            this.BtnMoveRight.Size = new System.Drawing.Size(76, 59);
            this.BtnMoveRight.TabIndex = 0;
            this.BtnMoveRight.Text = "Move Right";
            this.BtnMoveRight.UseVisualStyleBackColor = true;
            this.BtnMoveRight.Click += new System.EventHandler(this.MoveRight);
            // 
            // BtnMoveDown
            // 
            this.BtnMoveDown.Location = new System.Drawing.Point(90, 153);
            this.BtnMoveDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMoveDown.Name = "BtnMoveDown";
            this.BtnMoveDown.Size = new System.Drawing.Size(76, 59);
            this.BtnMoveDown.TabIndex = 0;
            this.BtnMoveDown.Text = "Move Down";
            this.BtnMoveDown.UseVisualStyleBackColor = true;
            this.BtnMoveDown.Click += new System.EventHandler(this.MoveDown);
            // 
            // BtnMoveToCenter
            // 
            this.BtnMoveToCenter.Location = new System.Drawing.Point(90, 22);
            this.BtnMoveToCenter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMoveToCenter.Name = "BtnMoveToCenter";
            this.BtnMoveToCenter.Size = new System.Drawing.Size(76, 59);
            this.BtnMoveToCenter.TabIndex = 0;
            this.BtnMoveToCenter.Text = "Move To Center";
            this.BtnMoveToCenter.UseVisualStyleBackColor = true;
            this.BtnMoveToCenter.Click += new System.EventHandler(this.MoveToCenter);
            // 
            // BtnMoveLeft
            // 
            this.BtnMoveLeft.Location = new System.Drawing.Point(7, 153);
            this.BtnMoveLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMoveLeft.Name = "BtnMoveLeft";
            this.BtnMoveLeft.Size = new System.Drawing.Size(76, 59);
            this.BtnMoveLeft.TabIndex = 0;
            this.BtnMoveLeft.Text = "Move Left";
            this.BtnMoveLeft.UseVisualStyleBackColor = true;
            this.BtnMoveLeft.Click += new System.EventHandler(this.MoveLeft);
            // 
            // BtnMoveUp
            // 
            this.BtnMoveUp.Location = new System.Drawing.Point(90, 88);
            this.BtnMoveUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMoveUp.Name = "BtnMoveUp";
            this.BtnMoveUp.Size = new System.Drawing.Size(76, 59);
            this.BtnMoveUp.TabIndex = 0;
            this.BtnMoveUp.Text = "Move Up";
            this.BtnMoveUp.UseVisualStyleBackColor = true;
            this.BtnMoveUp.Click += new System.EventHandler(this.MoveUp);
            // 
            // BtnMoveToOrigin
            // 
            this.BtnMoveToOrigin.Location = new System.Drawing.Point(7, 22);
            this.BtnMoveToOrigin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMoveToOrigin.Name = "BtnMoveToOrigin";
            this.BtnMoveToOrigin.Size = new System.Drawing.Size(76, 59);
            this.BtnMoveToOrigin.TabIndex = 0;
            this.BtnMoveToOrigin.Text = "Move to Origin";
            this.BtnMoveToOrigin.UseVisualStyleBackColor = true;
            this.BtnMoveToOrigin.Click += new System.EventHandler(this.MoveToOrigin);
            // 
            // NumBurningTime
            // 
            this.NumBurningTime.Location = new System.Drawing.Point(7, 42);
            this.NumBurningTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumBurningTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumBurningTime.Name = "NumBurningTime";
            this.NumBurningTime.Size = new System.Drawing.Size(159, 23);
            this.NumBurningTime.TabIndex = 0;
            this.NumBurningTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnSetBurningTime
            // 
            this.BtnSetBurningTime.Location = new System.Drawing.Point(173, 22);
            this.BtnSetBurningTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSetBurningTime.Name = "BtnSetBurningTime";
            this.BtnSetBurningTime.Size = new System.Drawing.Size(76, 59);
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
            this.GrpBurningTime.Location = new System.Drawing.Point(14, 407);
            this.GrpBurningTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpBurningTime.Name = "GrpBurningTime";
            this.GrpBurningTime.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpBurningTime.Size = new System.Drawing.Size(257, 91);
            this.GrpBurningTime.TabIndex = 1;
            this.GrpBurningTime.TabStop = false;
            this.GrpBurningTime.Text = "Burning time controls";
            // 
            // GrpEngravingControls
            // 
            this.GrpEngravingControls.Controls.Add(this.btnStop);
            this.GrpEngravingControls.Controls.Add(this.BtnLoadPicture);
            this.GrpEngravingControls.Controls.Add(this.BtnEngrave);
            this.GrpEngravingControls.Controls.Add(this.btnSendImageToMachine);
            this.GrpEngravingControls.Controls.Add(this.BtnPause);
            this.GrpEngravingControls.Enabled = false;
            this.GrpEngravingControls.Location = new System.Drawing.Point(14, 505);
            this.GrpEngravingControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpEngravingControls.Name = "GrpEngravingControls";
            this.GrpEngravingControls.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpEngravingControls.Size = new System.Drawing.Size(257, 148);
            this.GrpEngravingControls.TabIndex = 3;
            this.GrpEngravingControls.TabStop = false;
            this.GrpEngravingControls.Text = "Engraving controls";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(128, 22);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 27);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop engraving";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.Stop);
            // 
            // BtnLoadPicture
            // 
            this.BtnLoadPicture.Location = new System.Drawing.Point(7, 22);
            this.BtnLoadPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLoadPicture.Name = "BtnLoadPicture";
            this.BtnLoadPicture.Size = new System.Drawing.Size(114, 27);
            this.BtnLoadPicture.TabIndex = 3;
            this.BtnLoadPicture.Text = "Load picture";
            this.BtnLoadPicture.UseVisualStyleBackColor = true;
            this.BtnLoadPicture.Click += new System.EventHandler(this.LoadPicture);
            // 
            // BtnEngrave
            // 
            this.BtnEngrave.Location = new System.Drawing.Point(173, 55);
            this.BtnEngrave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEngrave.Name = "BtnEngrave";
            this.BtnEngrave.Size = new System.Drawing.Size(76, 85);
            this.BtnEngrave.TabIndex = 1;
            this.BtnEngrave.Text = "Engrave";
            this.BtnEngrave.UseVisualStyleBackColor = true;
            this.BtnEngrave.Click += new System.EventHandler(this.EngravePicture);
            // 
            // btnSendImageToMachine
            // 
            this.btnSendImageToMachine.Location = new System.Drawing.Point(90, 55);
            this.btnSendImageToMachine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendImageToMachine.Name = "btnSendImageToMachine";
            this.btnSendImageToMachine.Size = new System.Drawing.Size(76, 85);
            this.btnSendImageToMachine.TabIndex = 1;
            this.btnSendImageToMachine.Text = "Send image to machine";
            this.btnSendImageToMachine.UseVisualStyleBackColor = true;
            this.btnSendImageToMachine.Click += new System.EventHandler(this.SendImageToMachine);
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(7, 55);
            this.BtnPause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(76, 85);
            this.BtnPause.TabIndex = 1;
            this.BtnPause.Text = "Pause engraving";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.PauseEngraving);
            // 
            // GrpPicture
            // 
            this.GrpPicture.Controls.Add(this.label4);
            this.GrpPicture.Controls.Add(this.label3);
            this.GrpPicture.Controls.Add(this.label2);
            this.GrpPicture.Controls.Add(this.label1);
            this.GrpPicture.Controls.Add(this.PbxToEngrave);
            this.GrpPicture.Controls.Add(this.PbxOriginal);
            this.GrpPicture.Enabled = false;
            this.GrpPicture.Location = new System.Drawing.Point(278, 14);
            this.GrpPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpPicture.Name = "GrpPicture";
            this.GrpPicture.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpPicture.Size = new System.Drawing.Size(1191, 639);
            this.GrpPicture.TabIndex = 4;
            this.GrpPicture.TabStop = false;
            this.GrpPicture.Text = "Picture to engrave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1094, 617);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Machine Front";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1094, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Machine Rear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Picture to engrave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original picture";
            // 
            // PbxToEngrave
            // 
            this.PbxToEngrave.Location = new System.Drawing.Point(597, 37);
            this.PbxToEngrave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PbxToEngrave.MaximumSize = new System.Drawing.Size(583, 577);
            this.PbxToEngrave.MinimumSize = new System.Drawing.Size(583, 577);
            this.PbxToEngrave.Name = "PbxToEngrave";
            this.PbxToEngrave.Size = new System.Drawing.Size(583, 577);
            this.PbxToEngrave.TabIndex = 1;
            this.PbxToEngrave.TabStop = false;
            // 
            // PbxOriginal
            // 
            this.PbxOriginal.Location = new System.Drawing.Point(7, 37);
            this.PbxOriginal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PbxOriginal.MaximumSize = new System.Drawing.Size(583, 577);
            this.PbxOriginal.MinimumSize = new System.Drawing.Size(583, 577);
            this.PbxOriginal.Name = "PbxOriginal";
            this.PbxOriginal.Size = new System.Drawing.Size(583, 577);
            this.PbxOriginal.TabIndex = 0;
            this.PbxOriginal.TabStop = false;
            // 
            // ChkKeepAspectRatio
            // 
            this.ChkKeepAspectRatio.AutoSize = true;
            this.ChkKeepAspectRatio.Location = new System.Drawing.Point(7, 46);
            this.ChkKeepAspectRatio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkKeepAspectRatio.Name = "ChkKeepAspectRatio";
            this.ChkKeepAspectRatio.Size = new System.Drawing.Size(116, 19);
            this.ChkKeepAspectRatio.TabIndex = 3;
            this.ChkKeepAspectRatio.Text = "Keep aspect ratio";
            this.ChkKeepAspectRatio.UseVisualStyleBackColor = true;
            this.ChkKeepAspectRatio.CheckStateChanged += new System.EventHandler(this.RecalulatePictureBoxes);
            // 
            // ChkStretchToSize
            // 
            this.ChkStretchToSize.AutoSize = true;
            this.ChkStretchToSize.Location = new System.Drawing.Point(7, 20);
            this.ChkStretchToSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkStretchToSize.Name = "ChkStretchToSize";
            this.ChkStretchToSize.Size = new System.Drawing.Size(158, 19);
            this.ChkStretchToSize.TabIndex = 3;
            this.ChkStretchToSize.Text = "Scale picture to 512 x 512";
            this.ChkStretchToSize.UseVisualStyleBackColor = true;
            this.ChkStretchToSize.CheckStateChanged += new System.EventHandler(this.RecalulatePictureBoxes);
            // 
            // grpPictureManipulation
            // 
            this.grpPictureManipulation.Controls.Add(this.ChkKeepAspectRatio);
            this.grpPictureManipulation.Controls.Add(this.ChkStretchToSize);
            this.grpPictureManipulation.Location = new System.Drawing.Point(278, 660);
            this.grpPictureManipulation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPictureManipulation.Name = "grpPictureManipulation";
            this.grpPictureManipulation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPictureManipulation.Size = new System.Drawing.Size(1191, 142);
            this.grpPictureManipulation.TabIndex = 5;
            this.grpPictureManipulation.TabStop = false;
            this.grpPictureManipulation.Text = "Picture controls";
            // 
            // grpMachineStatus
            // 
            this.grpMachineStatus.Controls.Add(this.prgEngravingProgress);
            this.grpMachineStatus.Controls.Add(this.label7);
            this.grpMachineStatus.Controls.Add(this.label6);
            this.grpMachineStatus.Controls.Add(this.label5);
            this.grpMachineStatus.Controls.Add(this.txtYPosition);
            this.grpMachineStatus.Controls.Add(this.txtXPosition);
            this.grpMachineStatus.Controls.Add(this.txtMachineStatus);
            this.grpMachineStatus.Location = new System.Drawing.Point(14, 660);
            this.grpMachineStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMachineStatus.Name = "grpMachineStatus";
            this.grpMachineStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMachineStatus.Size = new System.Drawing.Size(257, 142);
            this.grpMachineStatus.TabIndex = 6;
            this.grpMachineStatus.TabStop = false;
            this.grpMachineStatus.Text = "Machine Status";
            // 
            // prgEngravingProgress
            // 
            this.prgEngravingProgress.Location = new System.Drawing.Point(10, 111);
            this.prgEngravingProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prgEngravingProgress.Maximum = 499;
            this.prgEngravingProgress.Name = "prgEngravingProgress";
            this.prgEngravingProgress.Size = new System.Drawing.Size(238, 20);
            this.prgEngravingProgress.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "X position";
            // 
            // txtYPosition
            // 
            this.txtYPosition.Location = new System.Drawing.Point(133, 82);
            this.txtYPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYPosition.Name = "txtYPosition";
            this.txtYPosition.Size = new System.Drawing.Size(116, 23);
            this.txtYPosition.TabIndex = 0;
            // 
            // txtXPosition
            // 
            this.txtXPosition.Location = new System.Drawing.Point(133, 52);
            this.txtXPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtXPosition.Name = "txtXPosition";
            this.txtXPosition.Size = new System.Drawing.Size(116, 23);
            this.txtXPosition.TabIndex = 0;
            // 
            // txtMachineStatus
            // 
            this.txtMachineStatus.Location = new System.Drawing.Point(133, 22);
            this.txtMachineStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMachineStatus.Name = "txtMachineStatus";
            this.txtMachineStatus.Size = new System.Drawing.Size(116, 23);
            this.txtMachineStatus.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 807);
            this.Controls.Add(this.grpMachineStatus);
            this.Controls.Add(this.grpPictureManipulation);
            this.Controls.Add(this.GrpPicture);
            this.Controls.Add(this.GrpEngravingControls);
            this.Controls.Add(this.GrpBurningTime);
            this.Controls.Add(this.GrpMovement);
            this.Controls.Add(this.GrpConnection);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            ((System.ComponentModel.ISupportInitialize)(this.PbxToEngrave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOriginal)).EndInit();
            this.grpPictureManipulation.ResumeLayout(false);
            this.grpPictureManipulation.PerformLayout();
            this.grpMachineStatus.ResumeLayout(false);
            this.grpMachineStatus.PerformLayout();
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
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnLoadPicture;
        private System.Windows.Forms.GroupBox GrpPicture;
        private System.Windows.Forms.PictureBox PbxOriginal;
        private System.Windows.Forms.PictureBox PbxToEngrave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkKeepAspectRatio;
        private System.Windows.Forms.CheckBox ChkStretchToSize;
        private System.Windows.Forms.Button btnSendImageToMachine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpPictureManipulation;
        private System.Windows.Forms.GroupBox grpMachineStatus;
        private System.Windows.Forms.TextBox txtYPosition;
        private System.Windows.Forms.TextBox txtXPosition;
        private System.Windows.Forms.TextBox txtMachineStatus;
        private System.Windows.Forms.ProgressBar prgEngravingProgress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStop;
    }
}

