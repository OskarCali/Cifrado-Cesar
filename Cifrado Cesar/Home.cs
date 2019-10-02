using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifrado_Cesar
{
    public partial class formHome : Form
    {
        public List<char> Abecedario { get; set; }
        private string _idioma;
        private string _opcion;

        private char[] _espMayus = new[]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S',
            'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private char[] _espMinus = new[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's',
            't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        public formHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            Abecedario = new List<char>();

            cmbBxAbc.SelectedIndex = 0;
            cmbBxOptions.SelectedIndex = 0;

            radBtnCipher.Checked = true;
        }

        private void CmbBxAbc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Abecedario.Clear();
            richTxtBxSource.Text = "";
            _idioma = cmbBxAbc.Text;

            switch (_opcion)
            {
                case "Minusculas":
                    Abecedario.AddRange(_espMinus);
                    break;
                case "Mayusculas":
                    Abecedario.AddRange(_espMayus);
                    break;
                case "Ambas":
                    Abecedario.AddRange(_espMayus);
                    Abecedario.AddRange(_espMinus);
                    break;
                default:
                    Abecedario.AddRange(_espMinus);
                    break;
            }

            if (_idioma.Equals("Ingles"))
            {
                Abecedario.Remove('ñ');
                Abecedario.Remove('Ñ');
            }

            numUDMove.Maximum = Abecedario.Count - 1;
            richTxtBxAbc.Text = Abecedario.toAbc();
        }

        private void CmbBxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Abecedario.Clear();
            richTxtBxSource.Text = "";
            _opcion = cmbBxOptions.Text;

            switch (_opcion)
            {
                case "Minusculas":
                    Abecedario.AddRange(_espMinus);
                    break;
                case "Mayusculas":
                    Abecedario.AddRange(_espMayus);
                    break;
                case "Ambas":
                    Abecedario.AddRange(_espMayus);
                    Abecedario.AddRange(_espMinus);
                    break;
                default:
                    Abecedario.AddRange(_espMinus);
                    break;
            }

            if (_idioma.Equals("Ingles"))
            {
                Abecedario.Remove('ñ');
                Abecedario.Remove('Ñ');
            }

            numUDMove.Maximum = Abecedario.Count - 1;
            richTxtBxAbc.Text = Abecedario.toAbc();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            richTxtBxResult.Text = "";
            string text = richTxtBxSource.Text;
            char newCaracter;
            int num = 0;

            foreach (var caracter in text)
            {
                if (radBtnCipher.Checked)
                {
                    num = (int)(Abecedario.IndexOf(caracter) + numUDMove.Value);
                }
                else if (radBtnDiscipher.Checked)
                {
                    num = (int) (numUDMove.Value - (Abecedario.IndexOf(caracter)));
                }

                int afterMod = /*Math.Abs*/(num % Abecedario.Count);
                if (afterMod < 0)
                {
                    afterMod += Abecedario.Count;
                }

                newCaracter = Abecedario[afterMod];
                //newCaracter = (char) ((Abecedario.IndexOf(caracter) + numUDMove.Value) % numUDMove.Maximum);
                richTxtBxResult.Text += newCaracter;
            }
        }

        private void BtnShowHide_Click(object sender, EventArgs e)
        {
            splitContInfo.Panel1Collapsed = !splitContInfo.Panel1Collapsed;
            btnShowHide.Text = splitContInfo.Panel1Collapsed ? "MOSTRAR" : "OCULTAR";
        }

        private void RichTxtBxSource_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Abecedario.Contains(e.KeyChar))
            {
                e.Handled = false;
            }
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            else
            {
                e.Handled = true;
            }
        }
    }
}
