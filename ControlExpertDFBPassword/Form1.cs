using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;

namespace ControlExpertDFBPassword
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Size = new Size(456, 350);
        }

        // Déclaration de la table ASCII
        readonly char[] AsciiTable =
        {
            ' ','!','\'','#','$','%','&','\'','(',')','*','+',',','-','.','/','0','1','2','3','4','5','6','7','8','9',':',';',
            '<','=','>','?','@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W',
            'X','Y','Z','[','\\',']','^','_','`','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s',
            't','u','v','w','x','y','z','{','|','}','~',
        };

        private void BtnFind_Click(object sender, EventArgs e)
        {
            TxtBResult.Text = "";
            string password = findPassword(TxtBPassword, TxtBPassword, AsciiTable);
            if (password != "")
            {
                GrpResult.Visible = true;
                this.Size = new Size(456, 430);
                TxtBResult.Text = password;
                Clipboard.SetText(password);
            }
            else
            {
                TxtBResult.Text = "Impossible de trouver le mot de passe";
            }

        }

        static string findPassword(TextBox TxtBPassword, TextBox TxtBResult, char[] Ascii)
        {
            // Variables
            string password = TxtBPassword.Text;
            char[] charAscii = Ascii;
            int j = 1;
            string decryptedPasswordNeg = "";
            string decryptedPasswordPos = "";
            List<string> tablePassword = new List<string> { };


            // Explode password to char array
            char[] charPassword = password.ToCharArray();

            // Iterate
            while (j < 10)
            {
                for (int f = 0; f < charPassword.Length; f++)
                {
                    for (int i = 0; i < charAscii.Length; i++)
                    {
                        if (charPassword[f] == '0')
                        {
                            decryptedPasswordNeg += '0';
                            decryptedPasswordPos += '0';
                            break;
                        }
                        if (charPassword[f] == charAscii[i])
                        {
                            if (i - j > 0)
                            {
                                decryptedPasswordNeg += charAscii[i - j];

                            }
                            else
                            {
                                decryptedPasswordNeg += charAscii[charAscii.Length - i - j];
                            }

                            if (i + j < charAscii.Length)
                            {
                                decryptedPasswordPos += charAscii[i + j];
                            }
                            else
                            {
                                decryptedPasswordNeg += charAscii[i + j - charAscii.Length];
                            }
                        }
                    }

                }
                tablePassword.Add(decryptedPasswordNeg);
                tablePassword.Add(decryptedPasswordPos);
                // RAZ Password
                decryptedPasswordNeg = "";
                decryptedPasswordPos = "";
                j++;
            }
            return tablePassword[15];
        }

    }
}
