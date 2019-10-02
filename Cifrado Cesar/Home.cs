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
            richTxtBxSource.Text = "";
            _idioma = cmbBxAbc.Text;
            _opcion = cmbBxOptions.Text;

            Abecedario = Cesar.cambioAbecedario(_opcion, _idioma);

            numUDMove.Maximum = Abecedario.Count - 1;
            richTxtBxAbc.Text = Abecedario.toAbc();
        }

        private void CmbBxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTxtBxSource.Text = "";
            _idioma = cmbBxAbc.Text;
            _opcion = cmbBxOptions.Text;

            Abecedario = Cesar.cambioAbecedario(_opcion, _idioma);

            numUDMove.Maximum = Abecedario.Count - 1;
            richTxtBxAbc.Text = Abecedario.toAbc();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string text = richTxtBxSource.Text;
            char newCaracter;
            int num = 0;

            richTxtBxResult.Text = "";

            foreach (var caracter in text)
            {
                if (radBtnCipher.Checked)
                {
                    num = (int) (Abecedario.IndexOf(caracter) + numUDMove.Value);
                }
                else if (radBtnDiscipher.Checked)
                {
                    num = (int) (Abecedario.IndexOf(caracter) - numUDMove.Value);
                }

                if (num < 0)
                {
                    num += Abecedario.Count;
                }

                int afterMod = /*Math.Abs*/(num % Abecedario.Count);

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
