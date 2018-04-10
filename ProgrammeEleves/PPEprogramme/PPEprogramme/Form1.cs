using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace PPEprogramme
{
    public partial class FenetreProgramme : Form
    {
        public FenetreProgramme()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSupprimer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLancer_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("user=adminRL;password=siojjr;database=rallyelecture;host=172.16.0.156");
            connexion.Open();
            if (checkBoxSupprimer.Checked) {
                string Item = (string)comboBoxClasse.SelectedItem;
                string[] id = Item.Split(' ');

                MySqlCommand sDeleteGroup = new MySqlCommand("delete from aauth_user_to_group where user_id = (select id from aauth_users where id = (select idauth from eleve where idClasse = @idClasse))",connexion);
                sDeleteGroup.Parameters.AddWithValue("@idClasse",id[0]);
                sDeleteGroup.ExecuteNonQuery();

                MySqlCommand sDeleteUser = new MySqlCommand("delete from aauth_users where id = (select idauth from eleve where idClasse = @idClasse)",connexion);
                sDeleteUser.Parameters.AddWithValue("@idClasse",id[0]);
                sDeleteUser.ExecuteNonQuery();

                
                MySqlCommand sDeleteEleves = new MySqlCommand("delete from eleve where idClasse = @idClasse", connexion);
                sDeleteEleves.Parameters.AddWithValue("@idClasse", id[0]);
                sDeleteEleves.ExecuteNonQuery();

                
                


                
                
            }

            string txt = tbrepertoire.Text + "\\" + checkedListBox.Text;
            //MessageBox.Show(txt);
            StreamReader reader = new StreamReader(txt);
            reader.ReadLine();
            
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] lecture = line.Split(';');
                string groupe = lecture[0];
                string nom = lecture[1];
                string prenom = lecture[2];
                string login = lecture[3];
                string idClasse = lecture[4];

                MySqlCommand chargerUser = new MySqlCommand("insert into aauth_users(email,pass) values(@login,......)",connexion);
                chargerUser.Parameters.AddWithValue("@login",login);

                MySqlCommand SelectId = new MySqlCommand("select id from aauth_users where email = @login",connexion);
                SelectId.Parameters.AddWithValue("@login",login);
                MySqlDataReader rdrid = SelectId.ExecuteReader();
                int idauth = rdrid;
                MessageBox.Show(Convert.ToString(idauth));

                MySqlCommand chargerEleve = new MySqlCommand("insert into eleve(nom,prenom,login,idClasse,idauth) values(@nom,@prenom,@login,@idClasse,@idauth);",connexion);
                chargerEleve.Parameters.AddWithValue("@nom",nom);
                chargerEleve.Parameters.AddWithValue("@prenom",prenom);
                chargerEleve.Parameters.AddWithValue("@login",login);
                chargerEleve.Parameters.AddWithValue("@idClasse",idClasse);
                chargerEleve.Parameters.AddWithValue("@idauth",idauth);
                chargerEleve.ExecuteNonQuery();
            }
            reader.Close();
            connexion.Close();
        }

        private void btnRepertoire_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openfildialog1 = new FolderBrowserDialog();
            //if(openfildialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    System.IO.StreamReader sr = new System.IO.StreamReader(openfildialog1.FileName);
            //    MessageBox.Show(sr.ReadToEnd());
            //    sr.Close();
            //}
            //openfildialog1.DefaultExt = "csv";
            //openfildialog1.Filter = "Fichier MapInfoFormat (*.csv)|*.csv";
            openfildialog1.ShowDialog();
            tbrepertoire.Text = openfildialog1.SelectedPath;
            string[] filepaths = Directory.GetFiles(openfildialog1.SelectedPath, "*.csv", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < filepaths.Length; i++)
            {
                checkedListBox.Items.Add(filepaths[i].Replace(openfildialog1.SelectedPath + "\\", ""));
            }
            //if (openfildialog1.FileNames.Length > 0)
            //{
                //foreach (string filename in openfildialog1.SafeFileNames)
                //{
                    //checkedListBox.Items.Add(filename);
                //}
            //}
            
        }

        private void tbrepertoire_TextChanged(object sender, EventArgs e)
        {
            this.btnRepertoire.Click += new System.EventHandler(this.btnRepertoire_Click);
        }

        private void FenetreProgramme_Load(object sender, EventArgs e)
        {
            string SConnexion;
            MySqlConnection connexion;
            SConnexion = "user=adminRL;password=siojjr;database=rallyelecture;host=172.16.0.156";
            connexion = new MySqlConnection(SConnexion);
            connexion.Open();
            string sSelectClasse = "select niveau.id, niveauScolaire, anneeScolaire from niveau inner join classe on classe.idNiveau = niveau.id";
            MySqlCommand SelectClasse = new MySqlCommand(sSelectClasse, connexion);
            MySqlDataReader reader = SelectClasse.ExecuteReader();
            while (reader.Read())
            {
                comboBoxClasse.Items.Add(reader["id"] + " " + reader["niveauScolaire"] + " " + reader["anneeScolaire"]);
            }
            reader.Close();
            connexion.Close();
        }

        public static string GetSha256FromString(string data)
        {
            var message = Encoding.ASCII.GetBytes(data);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";
            var hashValue = hashString.ComputeHash(message);
            foreach(byte x in hashValue)
            {
                hex += String.Format("{0:x2}",x);
            }
            return hex;
        }

        
    }
}
