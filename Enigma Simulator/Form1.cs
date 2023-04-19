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
                string res = "";
                foreach (char letter in txtBoxPlainTxt.Text)
                {
                    //rotors changes
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
                    rotors[0] = changedFRotor.ToString();

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
                    rotors[1] = changedSRotor.ToString();


                    //third rotor
                    if (changedSRotor[0] == 'W')
                    {
                        tRotorSet.Text = ((int.Parse(tRotorSet.Text) + 1) % 27).ToString();
                        tRotorSetInt = (int.Parse(tRotorSet.Text) - 1) % 26;
                    }
                    temp = rotors[2];
                    while (changedTRotor.ToString()[0] != (rotors[2][tRotorSetInt]))
                    {
                        for (int i = 0; i < 26; i++)
                        {
                            changedTRotor[i] = temp[(i + 1) % 26];

                        }
                        temp = changedTRotor.ToString();

                    }
                    rotors[2] = changedTRotor.ToString();
                    char lf = letter;
                    for (int i = 0; i < 3; i++)
                    {
                        lf = rotors[i][alphabet.IndexOf(lf)];
                        if (i == 2)
                        {
                            if (cB1.Text == "UKW B")
                            {
                                switch (lf)
                                {
                                    case 'A':
                                        lf = 'Y';
                                        break;
                                    case 'Y':
                                        lf = 'A';
                                        break;
                                    case 'B':
                                        lf = 'R';
                                        break;
                                    case 'R':
                                        lf = 'B';
                                        break;
                                    case 'C':
                                        lf = 'U';
                                        break;
                                    case 'U':
                                        lf = 'C';
                                        break;
                                    case 'D':
                                        lf = 'H';
                                        break;
                                    case 'H':
                                        lf = 'D';
                                        break;
                                    case 'E':
                                        lf = 'Q';
                                        break;
                                    case 'Q':
                                        lf = 'E';
                                        break;
                                    case 'F':
                                        lf = 'S';
                                        break;
                                    case 'S':
                                        lf = 'F';
                                        break;
                                    case 'G':
                                        lf = 'L';
                                        break;
                                    case 'L':
                                        lf = 'G';
                                        break;
                                    case 'I':
                                        lf = 'P';
                                        break;
                                    case 'P':
                                        lf = 'I';
                                        break;
                                    case 'J':
                                        lf = 'X';
                                        break;
                                    case 'X':
                                        lf = 'J';
                                        break;
                                    case 'K':
                                        lf = 'N';
                                        break;
                                    case 'N':
                                        lf = 'K';
                                        break;
                                    case 'M':
                                        lf = 'O';
                                        break;
                                    case 'O':
                                        lf = 'M';
                                        break;
                                    case 'T':
                                        lf = 'Z';
                                        break;
                                    case 'Z':
                                        lf = 'T';
                                        break;
                                    case 'V':
                                        lf = 'W';
                                        break;
                                    case 'W':
                                        lf = 'V';
                                        break;
                                }
                            }
                        }
                    }

                    for (int i = 2; i >= 0; i--)
                    {
                        lf = alphabet[rotors[i].IndexOf(lf)];
                    }
                    res += lf;
                    

                }
                lblResult.Text = res;




            }


        }
    }
}