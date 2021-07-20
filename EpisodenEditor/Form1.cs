using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace EpisodenEditor
{
    public partial class frmPodcastEditor : Form
    {
        private PodcastEpisode podcastEpisode;
        public frmPodcastEditor()
        {
            InitializeComponent();

            // Steuerelemente deaktivieren sodass erst nach einem Laden eines bereits vorhandenen Dokuments oder bei Erstellung eines neuen Dokuments diese aktiv werden
            this.tbUserName.Enabled = false;
            this.tbGUID.Enabled = false;
            this.tbEpisodenTitel.Enabled = false;
            this.tbHosts.Enabled = false;
            this.tbSpotifyUrl.Enabled = false;
            this.tbAmazonUrl.Enabled = false;
            this.tbYoutubeUrl.Enabled = false;

            this.lbTopics.Enabled = false;
            this.btnTopicHinzufuegen.Enabled = false;
            this.btnTopicEntfernen.Enabled = false;

            this.gbTopic.Enabled = false;
            this.dtpStartZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);
            this.dtpEndZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);
        }

        private void btnNeueAbschrift_Click(object sender, EventArgs e)
        {
            // Todo: Prüfen ob bereits eine PodcasteFolge Objekt vorhanden ist und Meldung "Sicher neu erstellen, Fortschritt geht verloren" Meldung anzeigen
            this.podcastEpisode = new PodcastEpisode();
            this.podcastEpisode.topics = new List<Topic>();
            this.lbTopics.Items.Clear();

            this.tbUserName.Enabled = false;
            this.tbGUID.Enabled = false;
            this.tbEpisodenTitel.Enabled = false;
            this.tbHosts.Enabled = false;
            this.tbSpotifyUrl.Enabled = false;
            this.tbAmazonUrl.Enabled = false;
            this.tbYoutubeUrl.Enabled = false;

            this.lbTopics.Enabled = false;
            this.btnTopicHinzufuegen.Enabled = false;
            this.btnTopicEntfernen.Enabled = false;

            this.gbTopic.Enabled = false;
            this.dtpStartZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);
            this.dtpEndZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);

            // Kopfdaten leeren
            this.tbUserName.Text = string.Empty;
            this.tbGUID.Text = string.Empty;
            this.tbEpisodenTitel.Text = string.Empty;
            this.tbHosts.Text = string.Empty;
            this.tbSpotifyUrl.Text = string.Empty;
            this.tbYoutubeUrl.Text = string.Empty;
            this.tbAmazonUrl.Text = string.Empty;

            // Steuerelemente aktivieren für Eingabe der Kopfdaten
            this.tbUserName.Enabled = true;
            this.tbGUID.Enabled = true;
            this.tbEpisodenTitel.Enabled = true;
            this.tbHosts.Enabled = true;
            this.tbSpotifyUrl.Enabled = true;
            this.tbAmazonUrl.Enabled = true;
            this.tbYoutubeUrl.Enabled = true;
            this.lbTopics.Enabled = true;
            this.btnTopicHinzufuegen.Enabled = true;
            this.btnTopicEntfernen.Enabled = true;

            // Steuerelemente reseten
            this.tbTopic.Text = string.Empty;
            this.cbCommunityTopic.Checked = false;
            this.cbWerbungEnthalten.Checked = false;
            this.dtpStartZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);
            this.dtpEndZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);
            this.tbSubTopics.Text = string.Empty;

            this.lbTopics.SelectedIndex = -1;
            this.lbTopics.SelectedItem = null;
        }

        private void btnAbschriftOeffnen_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                ofd.Multiselect = false;
                ofd.Filter = "YAML Datei|*.yml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        var yaml = sr.ReadToEnd();
                        var deserialzer = new Deserializer();
                        this.podcastEpisode = deserialzer.Deserialize<PodcastEpisode>(yaml);
                        this.lbTopics.Items.Clear();
                        this.tbUserName.Text = podcastEpisode.username;
                        this.tbGUID.Text = podcastEpisode.guid.ToString();
                        this.tbEpisodenTitel.Text = podcastEpisode.title;
                        this.tbHosts.Text = string.Join(" ", podcastEpisode.hosts);
                        this.tbSpotifyUrl.Text = podcastEpisode.spotify;
                        this.tbYoutubeUrl.Text = podcastEpisode.youtube;
                        this.tbAmazonUrl.Text = podcastEpisode.amazon;
                        this.podcastEpisode.topics.ForEach(x => this.lbTopics.Items.Add(x));

                        // Steuerelemente aktivieren für Eingabe der Kopfdaten
                        this.tbUserName.Enabled = true;
                        this.tbGUID.Enabled = true;
                        this.tbEpisodenTitel.Enabled = true;
                        this.tbHosts.Enabled = true;
                        this.tbSpotifyUrl.Enabled = true;
                        this.tbAmazonUrl.Enabled = true;
                        this.tbYoutubeUrl.Enabled = true;
                        this.lbTopics.Enabled = true;
                        this.btnTopicHinzufuegen.Enabled = true;
                        this.btnTopicEntfernen.Enabled = true;
                        this.gbTopic.Enabled = true;
                    }
                }
            }
        }

        private void btnAbschriftSpeichern_Click(object sender, EventArgs e)
        {
            this.podcastEpisode.username = this.tbUserName.Text;
            this.podcastEpisode.guid = this.tbGUID.Text;
            this.podcastEpisode.title = this.tbEpisodenTitel.Text;
            this.podcastEpisode.hosts = new List<string>(this.tbHosts.Text.Split(' '));
            this.podcastEpisode.spotify = this.tbSpotifyUrl.Text;
            this.podcastEpisode.youtube = this.tbYoutubeUrl.Text;
            this.podcastEpisode.amazon = this.tbAmazonUrl.Text;

            // Prüfen ob PodcastEpisode ein valides Objekt ist (alle Daten (Kopfdaten, Bauchdaten) angegeben)
            if (this.podcastEpisode is null)
            {
                // wenn nicht Meldung ausgeben
                MessageBox.Show("Kein Eintrag ausgewählt!", "Warnung!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // sonst serialisieren
                var serializer = new Serializer();
                var yaml = serializer.Serialize(this.podcastEpisode);
                using (var sfd = new SaveFileDialog())
                {
                    sfd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                    sfd.Filter = "YAML Datei|*.yml";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLine(yaml.ToCharArray());
                        }
                    } 
                }
            }
        }

        private void btnTopicSpeichern_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic()
            {
                name = tbTopic.Text,
                community = this.cbCommunityTopic.Checked,
                ad = this.cbWerbungEnthalten.Checked,
                start = new TimeSpan(this.dtpStartZeit.Value.Hour, this.dtpStartZeit.Value.Minute, this.dtpStartZeit.Value.Second),
                end = new TimeSpan(this.dtpEndZeit.Value.Hour, this.dtpEndZeit.Value.Minute, this.dtpEndZeit.Value.Second),
                subtopics = this.tbSubTopics.Text.Trim() == string.Empty ? new List<string>() : this.tbSubTopics.Text.Replace("\r\n", "\n").Split('\n').ToList(),
        };
            this.podcastEpisode.topics.Add(topic);
            this.lbTopics.Items.Add(topic);

            // Steuerelemente reseten
            this.tbTopic.Text = string.Empty;
            this.cbCommunityTopic.Checked = false;
            this.cbWerbungEnthalten.Checked = false;
            this.dtpStartZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);
            this.dtpEndZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);
            this.tbSubTopics.Text = string.Empty;
            this.gbTopic.Enabled = false;
        }

        private void btnTopicHinzufuegen_Click(object sender, EventArgs e)
        {
            this.gbTopic.Enabled = true;

            // Steuerelemente reseten
            this.tbTopic.Text = string.Empty;
            this.cbCommunityTopic.Checked = false;
            this.cbWerbungEnthalten.Checked = false;
            this.dtpStartZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);
            this.dtpEndZeit.Value = new DateTime(1999, 01, 01, 0, 0, 0);
            this.tbSubTopics.Text = string.Empty;

            this.lbTopics.SelectedIndex = -1;
            this.lbTopics.SelectedItem = null;
        }

        private void btnTopicEntfernen_Click(object sender, EventArgs e)
        {
            // Prüfen ob Eintrag ausgewählt
            if (this.lbTopics.SelectedIndex == -1)
            {
                MessageBox.Show("Kein Eintrag ausgewählt!", "Warnung!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                // wenn ausgewählt dann fragen ob wirklich löschenn
                // wenn nichts ausgewählt ist Meldung anzeigen
                var result = MessageBox.Show("Eintrag wirklich löschen?", "Meldung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    var selectedItem = this.lbTopics.SelectedItem as Topic;
                    this.lbTopics.Items.Remove(selectedItem);
                    this.podcastEpisode.topics.Remove(selectedItem);
                }
            }

            this.lbTopics.SelectedIndex = -1;
            this.lbTopics.SelectedItem = null;
        }

        private void lbTopics_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbTopics.IndexFromPoint(e.Location);
            if (index  != ListBox.NoMatches)
            {
                var topic = this.lbTopics.Items[index] as Topic;
                this.tbTopic.Text = topic.name;
                this.cbCommunityTopic.Checked = topic.community;
                this.cbWerbungEnthalten.Checked = topic.ad;
                this.dtpStartZeit.Value = new DateTime(1999, 1, 1, topic.start.Hours, topic.start.Minutes, topic.start.Seconds);
                this.dtpEndZeit.Value = new DateTime(1999, 1, 1, topic.end.Hours, topic.end.Minutes, topic.end.Seconds);

                this.tbSubTopics.Text = string.Join(Environment.NewLine, topic.subtopics);
            }
            this.gbTopic.Enabled = true;
        }
    }
}
