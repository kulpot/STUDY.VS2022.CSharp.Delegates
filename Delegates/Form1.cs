using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ref link:https://www.youtube.com/watch?v=y3mv3Xe5aGE&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=61
// Defining and instantiating delegates

namespace Delegates
{
    public delegate int GetNumberDelegate(int num);

    public partial class Form1 : Form
    {
        //public delegate int GetNumberDelegate(int num);

        public Form1()
        {
            InitializeComponent();

            //MethodInvoker // points to method that returns void and takes no parameters which is very common
            //EventHandler  // when using this delegate type you need to decorate this with event key word
            //Delegate  // based of all the delegate 
            GetNumberDelegate GetBigNumHook = new GetNumberDelegate(GetBigNum); // instance delegate declaration
            this.Text = GetBigNumHook.Invoke(45).ToString();
            //this.Text = GetBigNumHook.BeginInvoke(45, ).ToString();

        }

        public int GetBigNum(int num)
        {
            return int.MaxValue;
        }
    } 
}
