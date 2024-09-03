namespace Streaming
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_options = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_next.FlatAppearance.BorderSize = 10;
            this.btn_next.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.Red;
            this.btn_next.Location = new System.Drawing.Point(245, 16);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(78, 39);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Black;
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_open.FlatAppearance.BorderSize = 10;
            this.btn_open.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.Red;
            this.btn_open.Location = new System.Drawing.Point(552, 16);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(122, 39);
            this.btn_open.TabIndex = 11;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Black;
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Stop.FlatAppearance.BorderSize = 10;
            this.btn_Stop.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.Red;
            this.btn_Stop.Location = new System.Drawing.Point(448, 16);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(78, 39);
            this.btn_Stop.TabIndex = 10;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Black;
            this.btn_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pause.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pause.FlatAppearance.BorderSize = 10;
            this.btn_pause.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.ForeColor = System.Drawing.Color.Red;
            this.btn_pause.Location = new System.Drawing.Point(347, 16);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(78, 39);
            this.btn_pause.TabIndex = 9;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Black;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_play.FlatAppearance.BorderSize = 10;
            this.btn_play.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.Red;
            this.btn_play.Location = new System.Drawing.Point(143, 16);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(78, 39);
            this.btn_play.TabIndex = 8;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.BackColor = System.Drawing.Color.Black;
            this.btn_Prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Prev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Prev.FlatAppearance.BorderSize = 10;
            this.btn_Prev.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prev.ForeColor = System.Drawing.Color.Red;
            this.btn_Prev.Location = new System.Drawing.Point(44, 16);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(78, 39);
            this.btn_Prev.TabIndex = 7;
            this.btn_Prev.Text = "Preview";
            this.btn_Prev.UseVisualStyleBackColor = false;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(85, 51);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(545, 15);
            this.p_bar.TabIndex = 13;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.Black;
            this.track_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_list.ForeColor = System.Drawing.Color.Red;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(260, 139);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(434, 244);
            this.track_list.TabIndex = 14;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // pic_art
            // 
            this.pic_art.Image = global::Streaming.Properties.Resources.cd_aesthetic;
            this.pic_art.Location = new System.Drawing.Point(25, 139);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(229, 239);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 15;
            this.pic_art.TabStop = false;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(717, 119);
            this.player.TabIndex = 16;
            // 
            // track_volume
            // 
            this.track_volume.BackColor = System.Drawing.Color.Black;
            this.track_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.track_volume.Location = new System.Drawing.Point(25, 419);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(238, 45);
            this.track_volume.TabIndex = 17;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Volume";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.Transparent;
            this.lbl_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.ForeColor = System.Drawing.Color.Red;
            this.lbl_volume.Location = new System.Drawing.Point(282, 428);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(71, 25);
            this.lbl_volume.TabIndex = 19;
            this.lbl_volume.Text = "100%";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.BackColor = System.Drawing.Color.Black;
            this.lbl_track_start.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.Red;
            this.lbl_track_start.Location = new System.Drawing.Point(12, 44);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(65, 22);
            this.lbl_track_start.TabIndex = 20;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.BackColor = System.Drawing.Color.Black;
            this.lbl_track_end.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.Red;
            this.lbl_track_end.Location = new System.Drawing.Point(636, 44);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(65, 22);
            this.lbl_track_end.TabIndex = 21;
            this.lbl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btn_open);
            this.panel1.Controls.Add(this.btn_Prev);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.btn_Stop);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 66);
            this.panel1.TabIndex = 22;
            // 
            // btn_options
            // 
            this.btn_options.BackColor = System.Drawing.Color.Black;
            this.btn_options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_options.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_options.FlatAppearance.BorderSize = 10;
            this.btn_options.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_options.ForeColor = System.Drawing.Color.Red;
            this.btn_options.Location = new System.Drawing.Point(616, 445);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(100, 32);
            this.btn_options.TabIndex = 23;
            this.btn_options.Text = "Options";
            this.btn_options.UseVisualStyleBackColor = false;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msg.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg.Location = new System.Drawing.Point(423, 386);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(125, 24);
            this.lbl_msg.TabIndex = 24;
            this.lbl_msg.Text = "Music Player";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Streaming.Properties.Resources.red_and_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 478);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.track_list);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Label lbl_msg;
    }
}