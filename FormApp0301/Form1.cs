using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0301
{
    public partial class Form1 : Form
    {
        private Button testButton = new Button();
        public Form1()
        {
            InitializeComponent();

            //自己添加一个按钮
            Controls.Add(testButton);
            testButton.Text = "我的测试";
        }
    }
}
