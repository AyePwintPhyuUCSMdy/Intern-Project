using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
namespace Dashboard
{


    public partial class TestUserControl1 : UserControl
    {
        public TestUserControl1()
        {
            InitializeComponent();
        }

        private void TestUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        //I write
        [DefaultEvent(nameof(TextChanged))]
        public partial class ClearableTextBox : UserControl { 
        }

        //I write
        public new event EventHandler TextChanged
        {
            add => txtValue.TextChanged += value;
            remove => txtValue.TextChanged -= value;
        }

        //I write
        public new string Text
        {
            get => txtValue.Text;
            set => txtValue.Text = value;
        }

        //I write
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Text = "";
        }
    }
}

