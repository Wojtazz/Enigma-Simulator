using System.Text;

namespace Enigma_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            cB1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            string[] rotors = new string[3];
            switch (cB2.Text)
            {
                case "I":
                    rotors[0] = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
                    break;
                case "II":
                    rotors[0] = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
                    break;
                case "III":
                    rotors[0] = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
                    break;
            }
            switch (cB3.Text)
            {
                case "I":
                    rotors[1] = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
                    break;
                case "II":
                    rotors[1] = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
                    break;
                case "III":
                    rotors[1] = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
                    break;
            }
            switch (cB4.Text)
            {
                case "I":
                    rotors[2] = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
                    break;
                case "II":
                    rotors[2] = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
                    break;
                case "III":
                    rotors[2] = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
                    break;
            }
            if (fRotorSet.Text != "")
            {
                int fRotorSetInt = int.Parse(fRotorSet.Text) % 26;
                int sRotorSetInt = (int.Parse(sRotorSet.Text) - 1) % 26;
                int tRotorSetInt = (int.Parse(tRotorSet.Text) - 1) % 26;
                fRotorSet.Text = ((int.Parse(fRotorSet.Text) + 1) % 27).ToString();
                if (fRotorSet.Text == "0")
                {
                    fRotorSet.Text = "1";
                }
                StringBuilder changedFRotor = new StringBuilder(rotors[0]);
                StringBuilder changedSRotor = new StringBuilder(rotors[1]);
                StringBuilder changedTRotor = new StringBuilder(rotors[2]);
                //first rotor
                string temp = rotors[0];
                while (changedFRotor.ToString()[0] != (rotors[0][fRotorSetInt]))
                {
                    for (int i = 0; i < 26; i++)
                    {
                        changedFRotor[i] = temp[(i + 1) % 26];

                    }
                    temp = changedFRotor.ToString();

                }

                //second rotor
                if (changedFRotor[0] == 'Q')
                {
                    sRotorSet.Text = ((int.Parse(sRotorSet.Text) + 1) % 27).ToString();
                    sRotorSetInt = (int.Parse(sRotorSet.Text) - 1) % 26;
                }
                temp = rotors[1];
                while (changedSRotor.ToString()[0] != (rotors[1][sRotorSetInt]))
                {
                    for (int i = 0; i < 26; i++)
                    {
                        changedSRotor[i] = temp[(i + 1) % 26];

                    }
                    temp = changedSRotor.ToString();

                }


                //third rotor
                if (changedSRotor[0] == 'W')
                {
                    tRotorSet.Text = ((int.Parse(tRotorSet.Text) + 1) % 27).ToString();
                    tRotorSetInt = (int.Parse(tRotorSet.Text) - 1) % 26;
                }
                temp = rotors[2];
                while (changedTRotor.ToString()[0] != (rotors[1][tRotorSetInt]))
                {
                    for (int i = 0; i < 26; i++)
                    {
                        changedTRotor[i] = temp[(i + 1) % 26];

                    }
                    temp = changedTRotor.ToString();

                }





                lblResult.Text = changedSRotor.ToString();








            }


        }
    }
}