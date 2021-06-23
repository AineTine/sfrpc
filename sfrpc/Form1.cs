using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sfrpc.Tools.ProcessTools;

namespace sfrpc
{
    public partial class Form1 : Form
    {


        static String rootDir = System.Environment.CurrentDirectory;
        static String binDir = rootDir + "\\bin\\";
        static String confDir = rootDir + "\\conf\\";
        private List<Process> processes;

        [DllImport("shell32.dll")]
        public static extern int ShellExecute(IntPtr hwnd, StringBuilder lpszOp, StringBuilder lpszFile, StringBuilder lpszParams, StringBuilder lpszDir, int FsShowCmd);
        public Form1()
        {
            InitializeComponent();
        }

        // 打开配置文件
        private void editconf_Click(object sender, EventArgs e)
        {
            ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder("frpc.ini"), new StringBuilder(""), new StringBuilder(confDir), 1);
            Console.WriteLine(confDir);
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            processes = System.Diagnostics.Process.GetProcessesByName("frpc").ToList();
            // 检查FRPC是否已经运行
            if (processes.Count > 0)
            {
                info.Text = info.Text + "\r\n" + "执行成功，代理已销毁";
                // 遍历进程组，结束所有frpc进程
                foreach (var process in processes)
                {
                    process.Kill();
                }
                Operator.Text = "启动Frpc代理";
            }
            else
            {
                info.Text = info.Text + "\r\n" + "执行成功，代理已启动";
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = binDir + "\\frpc.exe"; //启动的应用程序名称
                    startInfo.Arguments = "-c " + confDir + "\\frpc.ini";
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(startInfo);
                }
                catch (Exception)
                {
                    throw;
                }
                Operator.Text = "销毁Frpc代理";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processes = System.Diagnostics.Process.GetProcessesByName("frpc").ToList();
            if (processes.Count > 0)
            {
                info.Text = info.Text + "\r\n" + "代理已启动";
                Operator.Text = "销毁Frpc代理";
            }
            else
            {
                info.Text = info.Text + "\r\n" + "代理未启动";
                Operator.Text = "启动Frpc代理";
            }
        }
    }
}
