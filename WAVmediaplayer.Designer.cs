namespace WAVmediapaly
{
    partial class WAVmediaplayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.location = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdWAVFile = new System.Windows.Forms.OpenFileDialog();
            this.tbProgress = new System.Windows.Forms.TrackBar();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Play = new System.Windows.Forms.PictureBox();
            this.btn_Replay = new System.Windows.Forms.PictureBox();
            this.btn_quit = new System.Windows.Forms.PictureBox();
            this.btn_Stop = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.location.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Replay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).BeginInit();
            this.SuspendLayout();
            // 
            // location
            // 
            this.location.Controls.Add(this.txtPath);
            this.location.Controls.Add(this.btnBrowse);
            this.location.Location = new System.Drawing.Point(53, 12);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(598, 100);
            this.location.TabIndex = 0;
            this.location.TabStop = false;
            this.location.Text = "音效位置";
            this.location.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPath.Location = new System.Drawing.Point(21, 33);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(387, 40);
            this.txtPath.TabIndex = 0;
            this.txtPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowse.Location = new System.Drawing.Point(444, 37);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(126, 36);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "瀏覽檔案";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdWAVFile
            // 
            this.ofdWAVFile.FileName = "ofdWAVFile";
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(108, 118);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(494, 45);
            this.tbProgress.TabIndex = 5;
            this.tbProgress.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(556, 166);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(33, 12);
            this.lblTotalTime.TabIndex = 6;
            this.lblTotalTime.Text = "label1";
            this.lblTotalTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // timerProgress
            // 
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(539, 212);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(112, 45);
            this.tbVolume.TabIndex = 7;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolume.Value = 50;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WAVmediapaly.Properties.Resources.sound;
            this.pictureBox1.Location = new System.Drawing.Point(497, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Play
            // 
            this.btn_Play.Image = global::WAVmediapaly.Properties.Resources.play;
            this.btn_Play.Location = new System.Drawing.Point(285, 201);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(46, 40);
            this.btn_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Play.TabIndex = 3;
            this.btn_Play.TabStop = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Replay
            // 
            this.btn_Replay.Image = global::WAVmediapaly.Properties.Resources.replay;
            this.btn_Replay.Location = new System.Drawing.Point(194, 201);
            this.btn_Replay.Name = "btn_Replay";
            this.btn_Replay.Size = new System.Drawing.Size(47, 40);
            this.btn_Replay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Replay.TabIndex = 4;
            this.btn_Replay.TabStop = false;
            this.btn_Replay.Click += new System.EventHandler(this.btn_Replay_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Image = global::WAVmediapaly.Properties.Resources.close;
            this.btn_quit.Location = new System.Drawing.Point(384, 201);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(46, 40);
            this.btn_quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quit.TabIndex = 2;
            this.btn_quit.TabStop = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Image = global::WAVmediapaly.Properties.Resources.stop;
            this.btn_Stop.Location = new System.Drawing.Point(285, 201);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(46, 40);
            this.btn_Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.TabStop = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(106, 166);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(32, 12);
            this.lblCurrentTime.TabIndex = 9;
            this.lblCurrentTime.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 253);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Replay);
            this.Controls.Add(this.location);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_Stop);
            this.Name = "Form1";
            this.Text = "WAV媒體播放器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.location.ResumeLayout(false);
            this.location.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Replay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox location;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdWAVFile;
        private System.Windows.Forms.PictureBox btn_Stop;
        private System.Windows.Forms.PictureBox btn_quit;
        private System.Windows.Forms.PictureBox btn_Replay;
        private System.Windows.Forms.PictureBox btn_Play;
        private System.Windows.Forms.TrackBar tbProgress;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentTime;
    }
}

