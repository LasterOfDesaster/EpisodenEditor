namespace EpisodenEditor
{
    partial class frmPodcastEditor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbGUID = new System.Windows.Forms.TextBox();
            this.tbEpisodenTitel = new System.Windows.Forms.TextBox();
            this.tbHosts = new System.Windows.Forms.TextBox();
            this.tbYoutubeUrl = new System.Windows.Forms.TextBox();
            this.tbSpotifyUrl = new System.Windows.Forms.TextBox();
            this.lbTopics = new System.Windows.Forms.ListBox();
            this.gbTopic = new System.Windows.Forms.GroupBox();
            this.dtpEndZeit = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTopicSpeichern = new System.Windows.Forms.Button();
            this.tbSubTopics = new System.Windows.Forms.TextBox();
            this.dtpStartZeit = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCommunityTopic = new System.Windows.Forms.CheckBox();
            this.cbWerbungEnthalten = new System.Windows.Forms.CheckBox();
            this.btnNeueAbschrift = new System.Windows.Forms.Button();
            this.btnAbschriftOeffnen = new System.Windows.Forms.Button();
            this.btnTopicHinzufuegen = new System.Windows.Forms.Button();
            this.btnTopicEntfernen = new System.Windows.Forms.Button();
            this.tbAmazonUrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAbschriftSpeichern = new System.Windows.Forms.Button();
            this.gbTopic.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "GUID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Spotify:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Youtube:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hosts:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(76, 54);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(221, 20);
            this.tbUserName.TabIndex = 4;
            // 
            // tbGUID
            // 
            this.tbGUID.Location = new System.Drawing.Point(76, 80);
            this.tbGUID.Name = "tbGUID";
            this.tbGUID.Size = new System.Drawing.Size(221, 20);
            this.tbGUID.TabIndex = 5;
            // 
            // tbEpisodenTitel
            // 
            this.tbEpisodenTitel.Location = new System.Drawing.Point(359, 54);
            this.tbEpisodenTitel.Name = "tbEpisodenTitel";
            this.tbEpisodenTitel.Size = new System.Drawing.Size(306, 20);
            this.tbEpisodenTitel.TabIndex = 6;
            // 
            // tbHosts
            // 
            this.tbHosts.Location = new System.Drawing.Point(359, 83);
            this.tbHosts.Name = "tbHosts";
            this.tbHosts.Size = new System.Drawing.Size(306, 20);
            this.tbHosts.TabIndex = 7;
            // 
            // tbYoutubeUrl
            // 
            this.tbYoutubeUrl.Location = new System.Drawing.Point(743, 80);
            this.tbYoutubeUrl.Name = "tbYoutubeUrl";
            this.tbYoutubeUrl.Size = new System.Drawing.Size(372, 20);
            this.tbYoutubeUrl.TabIndex = 9;
            // 
            // tbSpotifyUrl
            // 
            this.tbSpotifyUrl.Location = new System.Drawing.Point(743, 54);
            this.tbSpotifyUrl.Name = "tbSpotifyUrl";
            this.tbSpotifyUrl.Size = new System.Drawing.Size(372, 20);
            this.tbSpotifyUrl.TabIndex = 8;
            // 
            // lbTopics
            // 
            this.lbTopics.FormattingEnabled = true;
            this.lbTopics.Location = new System.Drawing.Point(15, 152);
            this.lbTopics.Name = "lbTopics";
            this.lbTopics.Size = new System.Drawing.Size(167, 355);
            this.lbTopics.TabIndex = 19;
            this.lbTopics.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTopics_MouseDoubleClick);
            // 
            // gbTopic
            // 
            this.gbTopic.Controls.Add(this.dtpEndZeit);
            this.gbTopic.Controls.Add(this.label10);
            this.gbTopic.Controls.Add(this.tbTopic);
            this.gbTopic.Controls.Add(this.label8);
            this.gbTopic.Controls.Add(this.btnTopicSpeichern);
            this.gbTopic.Controls.Add(this.tbSubTopics);
            this.gbTopic.Controls.Add(this.dtpStartZeit);
            this.gbTopic.Controls.Add(this.label7);
            this.gbTopic.Controls.Add(this.cbCommunityTopic);
            this.gbTopic.Controls.Add(this.cbWerbungEnthalten);
            this.gbTopic.Location = new System.Drawing.Point(206, 152);
            this.gbTopic.Name = "gbTopic";
            this.gbTopic.Size = new System.Drawing.Size(909, 394);
            this.gbTopic.TabIndex = 13;
            this.gbTopic.TabStop = false;
            this.gbTopic.Text = "Topics";
            // 
            // dtpEndZeit
            // 
            this.dtpEndZeit.CustomFormat = "hh:mm:tt";
            this.dtpEndZeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndZeit.Location = new System.Drawing.Point(697, 97);
            this.dtpEndZeit.Name = "dtpEndZeit";
            this.dtpEndZeit.Size = new System.Drawing.Size(86, 20);
            this.dtpEndZeit.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Endzeit:";
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(64, 31);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(551, 20);
            this.tbTopic.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Topic:";
            // 
            // btnTopicSpeichern
            // 
            this.btnTopicSpeichern.Location = new System.Drawing.Point(771, 349);
            this.btnTopicSpeichern.Name = "btnTopicSpeichern";
            this.btnTopicSpeichern.Size = new System.Drawing.Size(132, 23);
            this.btnTopicSpeichern.TabIndex = 18;
            this.btnTopicSpeichern.Text = "Topic speichern";
            this.btnTopicSpeichern.UseVisualStyleBackColor = true;
            this.btnTopicSpeichern.Click += new System.EventHandler(this.btnTopicSpeichern_Click);
            // 
            // tbSubTopics
            // 
            this.tbSubTopics.Location = new System.Drawing.Point(24, 71);
            this.tbSubTopics.Multiline = true;
            this.tbSubTopics.Name = "tbSubTopics";
            this.tbSubTopics.Size = new System.Drawing.Size(591, 301);
            this.tbSubTopics.TabIndex = 17;
            // 
            // dtpStartZeit
            // 
            this.dtpStartZeit.CustomFormat = "hh:mm:tt";
            this.dtpStartZeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartZeit.Location = new System.Drawing.Point(697, 68);
            this.dtpStartZeit.Name = "dtpStartZeit";
            this.dtpStartZeit.Size = new System.Drawing.Size(86, 20);
            this.dtpStartZeit.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Startzeit:";
            // 
            // cbCommunityTopic
            // 
            this.cbCommunityTopic.AutoSize = true;
            this.cbCommunityTopic.Location = new System.Drawing.Point(646, 33);
            this.cbCommunityTopic.Name = "cbCommunityTopic";
            this.cbCommunityTopic.Size = new System.Drawing.Size(119, 17);
            this.cbCommunityTopic.TabIndex = 13;
            this.cbCommunityTopic.Text = "Community Thema?";
            this.cbCommunityTopic.UseVisualStyleBackColor = true;
            // 
            // cbWerbungEnthalten
            // 
            this.cbWerbungEnthalten.AutoSize = true;
            this.cbWerbungEnthalten.Location = new System.Drawing.Point(771, 34);
            this.cbWerbungEnthalten.Name = "cbWerbungEnthalten";
            this.cbWerbungEnthalten.Size = new System.Drawing.Size(123, 17);
            this.cbWerbungEnthalten.TabIndex = 14;
            this.cbWerbungEnthalten.Text = "Werbung enthalten?";
            this.cbWerbungEnthalten.UseVisualStyleBackColor = true;
            // 
            // btnNeueAbschrift
            // 
            this.btnNeueAbschrift.Location = new System.Drawing.Point(12, 12);
            this.btnNeueAbschrift.Name = "btnNeueAbschrift";
            this.btnNeueAbschrift.Size = new System.Drawing.Size(132, 23);
            this.btnNeueAbschrift.TabIndex = 1;
            this.btnNeueAbschrift.Text = "Neue Abschrift";
            this.btnNeueAbschrift.UseVisualStyleBackColor = true;
            this.btnNeueAbschrift.Click += new System.EventHandler(this.btnNeueAbschrift_Click);
            // 
            // btnAbschriftOeffnen
            // 
            this.btnAbschriftOeffnen.Location = new System.Drawing.Point(150, 12);
            this.btnAbschriftOeffnen.Name = "btnAbschriftOeffnen";
            this.btnAbschriftOeffnen.Size = new System.Drawing.Size(132, 23);
            this.btnAbschriftOeffnen.TabIndex = 2;
            this.btnAbschriftOeffnen.Text = "Abschrift öffnen";
            this.btnAbschriftOeffnen.UseVisualStyleBackColor = true;
            this.btnAbschriftOeffnen.Click += new System.EventHandler(this.btnAbschriftOeffnen_Click);
            // 
            // btnTopicHinzufuegen
            // 
            this.btnTopicHinzufuegen.Location = new System.Drawing.Point(15, 513);
            this.btnTopicHinzufuegen.Name = "btnTopicHinzufuegen";
            this.btnTopicHinzufuegen.Size = new System.Drawing.Size(25, 25);
            this.btnTopicHinzufuegen.TabIndex = 11;
            this.btnTopicHinzufuegen.Text = "+";
            this.btnTopicHinzufuegen.UseVisualStyleBackColor = true;
            this.btnTopicHinzufuegen.Click += new System.EventHandler(this.btnTopicHinzufuegen_Click);
            // 
            // btnTopicEntfernen
            // 
            this.btnTopicEntfernen.Location = new System.Drawing.Point(157, 513);
            this.btnTopicEntfernen.Name = "btnTopicEntfernen";
            this.btnTopicEntfernen.Size = new System.Drawing.Size(25, 25);
            this.btnTopicEntfernen.TabIndex = 20;
            this.btnTopicEntfernen.Text = "-";
            this.btnTopicEntfernen.UseVisualStyleBackColor = true;
            this.btnTopicEntfernen.Click += new System.EventHandler(this.btnTopicEntfernen_Click);
            // 
            // tbAmazonUrl
            // 
            this.tbAmazonUrl.Location = new System.Drawing.Point(743, 108);
            this.tbAmazonUrl.Name = "tbAmazonUrl";
            this.tbAmazonUrl.Size = new System.Drawing.Size(372, 20);
            this.tbAmazonUrl.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(690, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Amazon:";
            // 
            // btnAbschriftSpeichern
            // 
            this.btnAbschriftSpeichern.Location = new System.Drawing.Point(288, 12);
            this.btnAbschriftSpeichern.Name = "btnAbschriftSpeichern";
            this.btnAbschriftSpeichern.Size = new System.Drawing.Size(132, 23);
            this.btnAbschriftSpeichern.TabIndex = 3;
            this.btnAbschriftSpeichern.Text = "Abschrift speichern";
            this.btnAbschriftSpeichern.UseVisualStyleBackColor = true;
            this.btnAbschriftSpeichern.Click += new System.EventHandler(this.btnAbschriftSpeichern_Click);
            // 
            // frmPodcastEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 644);
            this.Controls.Add(this.btnAbschriftSpeichern);
            this.Controls.Add(this.tbAmazonUrl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTopicEntfernen);
            this.Controls.Add(this.btnTopicHinzufuegen);
            this.Controls.Add(this.btnAbschriftOeffnen);
            this.Controls.Add(this.btnNeueAbschrift);
            this.Controls.Add(this.gbTopic);
            this.Controls.Add(this.lbTopics);
            this.Controls.Add(this.tbSpotifyUrl);
            this.Controls.Add(this.tbYoutubeUrl);
            this.Controls.Add(this.tbHosts);
            this.Controls.Add(this.tbEpisodenTitel);
            this.Controls.Add(this.tbGUID);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPodcastEditor";
            this.Text = "Podcast Editor";
            this.gbTopic.ResumeLayout(false);
            this.gbTopic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbGUID;
        private System.Windows.Forms.TextBox tbEpisodenTitel;
        private System.Windows.Forms.TextBox tbHosts;
        private System.Windows.Forms.TextBox tbYoutubeUrl;
        private System.Windows.Forms.TextBox tbSpotifyUrl;
        private System.Windows.Forms.ListBox lbTopics;
        private System.Windows.Forms.GroupBox gbTopic;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTopicSpeichern;
        private System.Windows.Forms.TextBox tbSubTopics;
        private System.Windows.Forms.DateTimePicker dtpStartZeit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbCommunityTopic;
        private System.Windows.Forms.CheckBox cbWerbungEnthalten;
        private System.Windows.Forms.Button btnNeueAbschrift;
        private System.Windows.Forms.Button btnAbschriftOeffnen;
        private System.Windows.Forms.Button btnTopicHinzufuegen;
        private System.Windows.Forms.Button btnTopicEntfernen;
        private System.Windows.Forms.TextBox tbAmazonUrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEndZeit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAbschriftSpeichern;
    }
}

