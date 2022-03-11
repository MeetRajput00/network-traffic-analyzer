namespace Network_Traffic_analyzer
{
    partial class dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.IPlocationButton = new System.Windows.Forms.Button();
            this.addIPButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.packetTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.panel8 = new System.Windows.Forms.Panel();
            this.anonymousIPText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.packetReceivedText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.packetSentText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.activeIPText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pauseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.IPlocationButton);
            this.panel1.Controls.Add(this.addIPButton);
            this.panel1.Controls.Add(this.dashboardButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 694);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.exitButton.Image = global::Network_Traffic_analyzer.Properties.Resources.icons8_exit_25;
            this.exitButton.Location = new System.Drawing.Point(-1, 649);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(248, 42);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // IPlocationButton
            // 
            this.IPlocationButton.FlatAppearance.BorderSize = 0;
            this.IPlocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IPlocationButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IPlocationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.IPlocationButton.Image = global::Network_Traffic_analyzer.Properties.Resources.icons8_map_25;
            this.IPlocationButton.Location = new System.Drawing.Point(0, 264);
            this.IPlocationButton.Name = "IPlocationButton";
            this.IPlocationButton.Size = new System.Drawing.Size(247, 42);
            this.IPlocationButton.TabIndex = 3;
            this.IPlocationButton.Text = "IP\'s Location";
            this.IPlocationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.IPlocationButton.UseVisualStyleBackColor = true;
            this.IPlocationButton.Click += new System.EventHandler(this.IPlocationButton_Click);
            // 
            // addIPButton
            // 
            this.addIPButton.FlatAppearance.BorderSize = 0;
            this.addIPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIPButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addIPButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addIPButton.Image = global::Network_Traffic_analyzer.Properties.Resources.icons8_add_25;
            this.addIPButton.Location = new System.Drawing.Point(0, 216);
            this.addIPButton.Name = "addIPButton";
            this.addIPButton.Size = new System.Drawing.Size(247, 42);
            this.addIPButton.TabIndex = 4;
            this.addIPButton.Text = "Add IP\'s     ";
            this.addIPButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addIPButton.UseVisualStyleBackColor = true;
            this.addIPButton.Click += new System.EventHandler(this.addIPButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dashboardButton.Image = global::Network_Traffic_analyzer.Properties.Resources.icons8_home_24;
            this.dashboardButton.Location = new System.Drawing.Point(-1, 168);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(248, 42);
            this.dashboardButton.TabIndex = 5;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 159);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Network_Traffic_analyzer.Properties.Resources.istockphoto_1285395672_170667a;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.packetTable);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.stopButton);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(253, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 688);
            this.panel3.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.filterCombo);
            this.panel10.Location = new System.Drawing.Point(243, 73);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(178, 62);
            this.panel10.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Filter:";
            // 
            // filterCombo
            // 
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Location = new System.Drawing.Point(49, 21);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.Size = new System.Drawing.Size(121, 23);
            this.filterCombo.TabIndex = 7;
            this.filterCombo.SelectedIndexChanged += new System.EventHandler(this.filterCombo_SelectedIndexChanged);
            // 
            // packetTable
            // 
            this.packetTable.BackColor = System.Drawing.SystemColors.Window;
            this.packetTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.packetTable.FullRowSelect = true;
            this.packetTable.GridLines = true;
            this.packetTable.Location = new System.Drawing.Point(29, 350);
            this.packetTable.Name = "packetTable";
            this.packetTable.Size = new System.Drawing.Size(737, 313);
            this.packetTable.TabIndex = 6;
            this.packetTable.UseCompatibleStateImageBehavior = false;
            this.packetTable.View = System.Windows.Forms.View.Details;
            this.packetTable.SelectedIndexChanged += new System.EventHandler(this.packetTable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S. No.";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time taken";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Source IP";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Destination IP";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Protocol";
            this.columnHeader5.Width = 140;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.anonymousIPText);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(212, 165);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(159, 149);
            this.panel8.TabIndex = 5;
            // 
            // anonymousIPText
            // 
            this.anonymousIPText.AutoSize = true;
            this.anonymousIPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.anonymousIPText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anonymousIPText.Location = new System.Drawing.Point(34, 51);
            this.anonymousIPText.Name = "anonymousIPText";
            this.anonymousIPText.Size = new System.Drawing.Size(69, 73);
            this.anonymousIPText.TabIndex = 1;
            this.anonymousIPText.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = " Anonymous IP\'s:";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.packetReceivedText);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(580, 165);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(159, 149);
            this.panel9.TabIndex = 4;
            // 
            // packetReceivedText
            // 
            this.packetReceivedText.AutoSize = true;
            this.packetReceivedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.packetReceivedText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.packetReceivedText.Location = new System.Drawing.Point(36, 51);
            this.packetReceivedText.Name = "packetReceivedText";
            this.packetReceivedText.Size = new System.Drawing.Size(69, 73);
            this.packetReceivedText.TabIndex = 1;
            this.packetReceivedText.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(4, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = " Packets received :";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.packetSentText);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(401, 165);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(159, 149);
            this.panel7.TabIndex = 4;
            // 
            // packetSentText
            // 
            this.packetSentText.AutoSize = true;
            this.packetSentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.packetSentText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.packetSentText.Location = new System.Drawing.Point(38, 51);
            this.packetSentText.Name = "packetSentText";
            this.packetSentText.Size = new System.Drawing.Size(69, 73);
            this.packetSentText.TabIndex = 1;
            this.packetSentText.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = " Packets sent:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.activeIPText);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(23, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 149);
            this.panel5.TabIndex = 4;
            // 
            // activeIPText
            // 
            this.activeIPText.AutoSize = true;
            this.activeIPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activeIPText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activeIPText.Location = new System.Drawing.Point(24, 47);
            this.activeIPText.Name = "activeIPText";
            this.activeIPText.Size = new System.Drawing.Size(69, 73);
            this.activeIPText.TabIndex = 1;
            this.activeIPText.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Active IP\'s:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stopButton.Image = global::Network_Traffic_analyzer.Properties.Resources.icons8_stop_squared_26;
            this.stopButton.Location = new System.Drawing.Point(170, 71);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(67, 62);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.startButton);
            this.panel6.Location = new System.Drawing.Point(20, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(71, 63);
            this.panel6.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Image = global::Network_Traffic_analyzer.Properties.Resources.icons8_start_26;
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(66, 59);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pauseButton);
            this.panel4.Location = new System.Drawing.Point(97, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 60);
            this.panel4.TabIndex = 3;
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pauseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pauseButton.Image = global::Network_Traffic_analyzer.Properties.Resources.icons8_pause_26;
            this.pauseButton.Location = new System.Drawing.Point(0, -3);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(67, 62);
            this.pauseButton.TabIndex = 0;
            this.pauseButton.Text = "Pause";
            this.pauseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1208, 694);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel pnlNav;
        private Button exitButton;
        private Button IPlocationButton;
        private Button addIPButton;
        private Button dashboardButton;
        private Label label1;
        private Panel panel3;
        private Panel panel5;
        private Label label2;
        private Button filterButton;
        private Button stopButton;
        private Panel panel6;
        private Button startButton;
        private Panel panel4;
        private Button pauseButton;
        private Label activeIPText;
        private Panel panel8;
        private Label anonymousIPText;
        private Label label7;
        private ListView packetTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Panel panel10;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox filterCombo;
        private Panel panel9;
        private Label packetReceivedText;
        private Label label9;
        private Panel panel7;
        private Label packetSentText;
        private Label label5;
    }
}