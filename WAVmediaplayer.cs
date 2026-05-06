using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;



namespace WAVmediapaly
{
    
    public partial class WAVmediaplayer : Form
    {
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;
        private bool isLooping = false; // 紀錄是否要重複播放



        public WAVmediaplayer()
        {
            InitializeComponent();
            btn_Play.Enabled = false;       // 播放按鈕停用
            btn_Replay.Enabled = false;       // 重複播放停用
            btn_Stop.Enabled = false;       // 停止按鈕停用
        }

        // --- 瀏覽檔案 ---
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdWAVFile.Filter = "WAV Files(*.wav)|*.wav";
            if (ofdWAVFile.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofdWAVFile.FileName;

                // 選新檔案時，先把舊的資源釋放，避免佔用
                DisposePlayback();

                btn_Play.Enabled = true;
                btn_Replay.Enabled = true;

                // 重置進度條
                tbProgress.Value = 0;
                lblCurrentTime.Text = "00:00";
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    

        // --- 播放 / 繼續 ---
        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text)) return;

            try
            {
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    audioFile = new AudioFileReader(txtPath.Text);
                    outputDevice.Init(audioFile);
                    outputDevice.PlaybackStopped += OnPlaybackStopped;

                    // 重要：設定進度條的最大值為音樂總秒數
                    tbProgress.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                }

                outputDevice.Play();
                timerProgress.Start();

                // UI 切換
                TogglePlayButtons(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("播放出錯：" + ex.Message);
            }
        }


        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
                timerProgress.Stop();
                TogglePlayButtons(false);
            }
        }

        // --- 重複播放 (切換開關) ---
        private void btn_Replay_Click(object sender, EventArgs e)
        {
            isLooping = !isLooping;

            if (isLooping)
            {
                btn_Replay.BackColor = Color.LightSkyBlue; // 變色提示開啟
            }
            else
            {
                btn_Replay.BackColor = SystemColors.Control; // 恢復原色
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            // 使用 Invoke 確保回到 UI 執行緒執行
            this.Invoke(new Action(() =>
            {
                if (isLooping && audioFile != null && outputDevice != null)
                {
                    // 重複播放邏輯
                    audioFile.Position = 0;
                    outputDevice.Play();
                    tbProgress.Value = 0;
                }
                else
                {
                    // 正常停止
                    timerProgress.Stop();
                    TogglePlayButtons(false);

                    // 如果播完了，把進度歸零
                    if (audioFile != null && audioFile.Position >= audioFile.Length)
                    {
                        audioFile.Position = 0;
                        tbProgress.Value = 0;
                        lblCurrentTime.Text = "00:00";
                    }
                }
            }));
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void ofdWAVFile_HelpRequest(object sender, EventArgs e)
        {
            // 使用完整檔名建立物件
            SoundPlayer player2 = new SoundPlayer(txtPath.Text);
            player2.PlayLooping();
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                // 當使用者拖曳滑桿時，把音樂目前的播放時間，改為滑桿所在的秒數
                audioFile.CurrentTime = TimeSpan.FromSeconds(tbProgress.Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // 為了避免手動拖曳時跟 Timer 互相干擾，設定一個變數
        private bool isDraggingProgress = false;

       

        // --- 音量控制 ---
        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Volume = tbVolume.Value / 100f;
            }
        }


         private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && !isDraggingProgress)
            {
                // 確保數值不超過最大值
                int currentSec = (int)audioFile.CurrentTime.TotalSeconds;
                tbProgress.Value = Math.Min(currentSec, tbProgress.Maximum);
                lblCurrentTime.Text = audioFile.CurrentTime.ToString(@"mm\:ss");
            }
        }
        private void tbProgress_MouseDown(object sender, MouseEventArgs e) { isDraggingProgress = true; }
        private void tbProgress_MouseUp(object sender, MouseEventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.CurrentTime = TimeSpan.FromSeconds(tbProgress.Value);
            }
            isDraggingProgress = false;
        }
        private void tbProgress_Scroll(object sender, EventArgs e)
        {
            TimeSpan dragTime = TimeSpan.FromSeconds(tbProgress.Value);
            lblCurrentTime.Text = dragTime.ToString(@"mm\:ss");
        }

        // --- 工具方法：切換按鈕顯示 ---
        private void TogglePlayButtons(bool playing)
        {
            btn_Play.Visible = !playing;
            btn_Play.Enabled = !playing;
            btn_Stop.Visible = playing;
            btn_Stop.Enabled = playing;
        }

        // --- 釋放資源 ---
        private void DisposePlayback()
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            outputDevice = null;
            audioFile?.Dispose();
            audioFile = null;
        }

        private void btn_quit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void frmWAVPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("確定要關閉嗎？", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
            else
                DisposePlayback();
        }
    }
}
