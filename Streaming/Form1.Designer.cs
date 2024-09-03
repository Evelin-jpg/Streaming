namespace Streaming
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_options = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Streaming.Properties.Resources.tabla_2;
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_volume);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.track_list);
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Controls.Add(this.btn_pause);
            this.groupBox1.Controls.Add(this.btn_play);
            this.groupBox1.Controls.Add(this.btn_Prev);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Thistle;
            this.groupBox1.Location = new System.Drawing.Point(15, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
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
            this.btn_next.ForeColor = System.Drawing.Color.Thistle;
            this.btn_next.Location = new System.Drawing.Point(213, 22);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(91, 40);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(685, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volume";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.Transparent;
            this.lbl_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.Location = new System.Drawing.Point(739, 87);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(28, 16);
            this.lbl_volume.TabIndex = 3;
            this.lbl_volume.Text = "0%";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Black;
            this.trackBar1.Location = new System.Drawing.Point(688, 22);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 141);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.track_list.ForeColor = System.Drawing.Color.White;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 20;
            this.track_list.Location = new System.Drawing.Point(12, 67);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(667, 104);
            this.track_list.TabIndex = 5;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
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
            this.btn_open.ForeColor = System.Drawing.Color.Thistle;
            this.btn_open.Location = new System.Drawing.Point(520, 22);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(91, 40);
            this.btn_open.TabIndex = 4;
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
            this.btn_Stop.ForeColor = System.Drawing.Color.Thistle;
            this.btn_Stop.Location = new System.Drawing.Point(416, 22);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(91, 40);
            this.btn_Stop.TabIndex = 3;
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
            this.btn_pause.ForeColor = System.Drawing.Color.Thistle;
            this.btn_pause.Location = new System.Drawing.Point(315, 22);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(91, 40);
            this.btn_pause.TabIndex = 2;
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
            this.btn_play.ForeColor = System.Drawing.Color.Thistle;
            this.btn_play.Location = new System.Drawing.Point(111, 22);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(91, 40);
            this.btn_play.TabIndex = 1;
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
            this.btn_Prev.ForeColor = System.Drawing.Color.Thistle;
            this.btn_Prev.Location = new System.Drawing.Point(12, 22);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(91, 40);
            this.btn_Prev.TabIndex = 0;
            this.btn_Prev.Text = "Previous";
            this.btn_Prev.UseVisualStyleBackColor = false;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msg.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_msg.Location = new System.Drawing.Point(11, 12);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(126, 24);
            this.lbl_msg.TabIndex = 2;
            this.lbl_msg.Text = "Media player";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Fuchsia;
            this.progressBar1.Location = new System.Drawing.Point(73, 364);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(661, 15);
            this.progressBar1.TabIndex = 3;
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.BackColor = System.Drawing.Color.Transparent;
            this.lbl_track_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_track_start.Location = new System.Drawing.Point(24, 364);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(43, 15);
            this.lbl_track_start.TabIndex = 6;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.BackColor = System.Drawing.Color.Transparent;
            this.lbl_track_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_track_end.Location = new System.Drawing.Point(740, 364);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(43, 15);
            this.lbl_track_end.TabIndex = 7;
            this.lbl_track_end.Text = "00:00";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(15, 55);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(777, 395);
            this.player.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btn_options.ForeColor = System.Drawing.Color.Thistle;
            this.btn_options.Location = new System.Drawing.Point(703, 2);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(100, 32);
            this.btn_options.TabIndex = 7;
            this.btn_options.Text = "Options";
            this.btn_options.UseVisualStyleBackColor = false;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Streaming.Properties.Resources.tabla_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 581);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_options;
    }
}

