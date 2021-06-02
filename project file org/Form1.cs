using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project_file_org
{

    public partial class Form1 : Form
    {
        public static string filename = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            filename = Application.StartupPath + "\\files\\"+ FilenametextBox.Text + ".txt";
            // If Folder Not Found Create It
            if (!File.Exists(Application.StartupPath + "\\files\\"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\files\\"); 
            }
            // Check If File Found Or no 
            // If File not found Create It
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
                warning.Text = "file created at  \n     " + Application.StartupPath + "\\files\\";
                warning.Visible = true;
                MessageBox.Show("File is created");
            }
            // If File Already Created show warning message
            else
            {
                warning.Text = "file already created at \n      " + Application.StartupPath + "\\files\\";
                warning.Visible = true;

            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            filename = Application.StartupPath + "\\files\\" + FilenametextBox.Text + ".txt";
            // Check File found or no
            // if not found show warning message " File not found"
            if (!File.Exists(filename))
            {

                warning.Text = " The file isn't found";
                warning.Visible = true;
                MessageBox.Show("The file isn't found");

            }
                // if file found Delete It
            else
            {
                File.Delete(filename);
                warning.Text = " The file is deleted";
                warning.Visible = true;
                MessageBox.Show("File is Deleted");

            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            filename = Application.StartupPath + "\\files\\" + FilenametextBox.Text + ".txt";

            // cleaning Richbox
            richbox.Text = " ";
            // check found file or no
            // if not found show warning message
            if (!File.Exists(filename))
            {
                warning.Text = "File not Found";
                warning.Visible = true;
            }
                // if file found 
            // read all lines and store it on Array Then loop on the array to append them to richbox line by line
            else
            {
                
                String[] FileLines = File.ReadAllLines(filename);   


                for (int b = 0; b < FileLines.Length; b++)
                {
                    if (b == 0)
                    {
                        richbox.AppendText(FileLines[b].Substring(1, FileLines[b].Length - 2) + "\n");
                    }
                    
                    else if(b==FileLines.Length-1){
                          richbox.AppendText(FileLines[b]);  
                    }
                    else
                    {
                        richbox.AppendText(FileLines[b].Substring(0, FileLines[b].Length - 1) + "\n");

                    }

                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            filename = Application.StartupPath + "\\files\\" + FilenametextBox.Text + ".txt";
            // check found file or no
            // if not found show warning message
            if (!File.Exists(filename))
            {
                warning.Text = " The file isn't found";
                warning.Visible = true;
                MessageBox.Show("The file isn't found");
                // open stream with file to write on it
            }else{
                BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Open, FileAccess.Write));
                int length = (int)bw.BaseStream.Length;
                if (length != 0)
                {
                    bw.BaseStream.Seek(length, SeekOrigin.Begin); // If the file is not empty, Append on it
                }
                //player_name.Text = player_name.Text.PadRight(player_name.Text.Length - 1); 
                bw.Write("The player name is:" + player_name.Text);

                //Positon.Text = Positon.Text.PadRight(Positon.Text.Length - 1);
                bw.Write("\nPlayer positon: " + Positon.Text);

                //Team.Text = Team.Text.PadRight(Team.Text.Length - 1);
                bw.Write("\nPlayer team: " + Team.Text);

                //player_nationality.Text = player_nationality.Text.PadRight(player_nationality.Text.Length - 1);
                bw.Write("\nHis nationality: " + player_nationality.Text + "\n");

                player_nationality.Text = Positon.Text = Team.Text = player_name.Text = " "; // making the input fields empty to take new input
                bw.Close();
                MessageBox.Show(" Data is Saved Successfully ");

            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            filename = Application.StartupPath + "\\files\\" + FilenametextBox.Text + ".txt";

            // Store File on Array "filelines"
            String[] filelines = File.ReadAllLines(filename);
            // Loob on Array "filelines" line by line
            for (int i = 0; i < filelines.Length; i++)
            {
                // if the text in search input found in stored file will print The Player Data 
                if (filelines[i].Contains(searchInput.Text))
                {
                    
                    richbox.Text = "The player data is: \n" + filelines[i].Substring(1, filelines[i].Length - 2) + "\n" + filelines[i + 1].Substring(0, filelines[i+1].Length - 1) + "\n" + filelines[i + 2].Substring(0, filelines[i+2].Length - 1) + "\n" + filelines[i + 3];

                }



            }
           
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void warning_Click(object sender, EventArgs e) { }
        private void FilenametextBox_TextChanged(object sender, EventArgs e) { }
        private void PositionnametextBox_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }



    }
}
