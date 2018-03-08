/**********************************************************
** �ļ����� AddTextForm.cs
** �ļ�����:����ı�����
**
**---------------------------------------------------------
**�޸���ʷ��¼��
**�޸�ʱ��      �޸���    �޸����ݸ�Ҫ
**2016-02-02    xwj       ����
**
**********************************************************/

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DrawTools
{
    public partial class AddTextForm : Form
    {
        private string text;

        public AddTextForm(string text)
        {
            InitializeComponent();

            this.text = text;
            this.textBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text.Trim();
        }

        public string Textvalues
        {
            get { return text; }
            set { text = value; }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox1.Text.Trim() == "")
                e.Cancel = true;
        }
    }
}