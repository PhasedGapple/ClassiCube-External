using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using static System.Net.Mime.MediaTypeNames;

namespace ClassiCube_Hack
{
    public partial class Form1 : Form
    {
        public string processName = "ClassiCube"; // Process name WITHOUT ".exe"
        public Process[] processes;
        public Process targetProcess;
        public int processID;
        public IntPtr hProcess;
        public bool injected = false;
        private bool PosFly;
        public bool HackMee = false;
        public string clientId = "not received";

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        static extern bool CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        const int PROCESS_ALL_ACCESS = 0x1F0FFF;
        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_QUERY_INFORMATION = 0x0400;

        public bool Noclip { get; private set; }
        public bool AutoMine { get; private set; }

        public Form1()
        {
            InitializeComponent();
            AutoMine = false;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Find the process
            processes = Process.GetProcessesByName(processName);
            string newestVersion = new System.Net.WebClient().DownloadString("https://raw.githubusercontent.com/PhasedGapple/HackMee-Website/refs/heads/main/versions/ClassiCube").Trim();
            string curVersion = "v0.06";
            if (newestVersion != curVersion)
            {
                var result = MessageBox.Show("You are using an outdated version of HackMee for ClassiCube. Please update to the latest version: " + newestVersion, "HackMee for ClassiCube", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    var startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "https://phasedgapple.github.io/HackMee-Website/downloads",
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(startInfo);

                }
            }
            if (processes.Length == 0)
            {
                MessageBox.Show("Process not found!", "HackMee for ClassiCube");
                return;
            }

            targetProcess = processes
             .FirstOrDefault(p => p.MainWindowTitle.EndsWith(")")); // Look for a process with a window title ending in ')'

            processID = targetProcess.Id;
            hProcess = OpenProcess(PROCESS_ALL_ACCESS, false, processID);
            if (hProcess == IntPtr.Zero)
            {
                MessageBox.Show("Failed to open process. Error: " + Marshal.GetLastWin32Error(), "HackMee for ClassiCube");
                return;
            }
            string clientid = "";
            int offset = 0x20A4F8; // Memory offset from base address
            IntPtr baseAddress = targetProcess.MainModule.BaseAddress;
            IntPtr targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            byte[] buffer = new byte[16];
            int bytesWritten;
            ReadProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);
            clientid = Encoding.ASCII.GetString(buffer);
            if (clientid.Length <= 75)
            {
                clientid = "Vanilla";
            }
            else
            {
                HackMee = true;
            }
            injected = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (injected == false)
            {
                MessageBox.Show("Please use the detect client button first!", "HackMee for ClassiCube");
                return;
            }

            if (Noclip == false)
            {
                int offset = 0x200F3A; // Memory offset from base address
                IntPtr baseAddress = targetProcess.MainModule.BaseAddress;
                IntPtr targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
                byte[] buffer = BitConverter.GetBytes(1);
                int bytesWritten;
                WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);
                Noclip = true;
            }
            else
            {
                int offset = 0x200F3A; // Memory offset from base address
                IntPtr baseAddress = targetProcess.MainModule.BaseAddress;
                IntPtr targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
                byte[] buffer = BitConverter.GetBytes(0);
                int bytesWritten;
                WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);
                Noclip = false;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (injected == false)
            {
                MessageBox.Show("Please use the detect client button first!", "HackMee for ClassiCube");
                return;
            }
            int offset = 0x200EC8; // Memory offset from base address
            IntPtr baseAddress = targetProcess.MainModule.BaseAddress;
            IntPtr targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            byte[] buffer = BitConverter.GetBytes(float.Parse(this.TextBox1.Text));
            int bytesWritten;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);

            offset = 0x200ECC; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = BitConverter.GetBytes(float.Parse(this.textBox2.Text));
            int bytesWritten2;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten2);

            offset = 0x200ED0; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = BitConverter.GetBytes(float.Parse(this.textBox3.Text));
            int bytesWritten3;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (injected == false)
            {
                MessageBox.Show("Please use the detect client button first!", "HackMee for ClassiCube");
                return;
            }
            
            button4.Text = "Loading (1/8)";
            int offset = 0x200F23; // Memory offset from base address
            IntPtr baseAddress = targetProcess.MainModule.BaseAddress;
            IntPtr targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            byte[] buffer = BitConverter.GetBytes(1);
            int bytesWritten;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);

            button4.Text = "Loading (2/8)";
            offset = 0x200F24; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = BitConverter.GetBytes(1);
            int bytesWritten2;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten2);

            button4.Text = "Loading (3/8)";
            offset = 0x200F25; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = BitConverter.GetBytes(1);
            int bytesWritten3;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten3);

            button4.Text = "Loading (4/8)";
            offset = 0x200F26; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = BitConverter.GetBytes(1);
            int bytesWritten4;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten4);

            button4.Text = "Loading (5/8)";
            offset = 0x200F27; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = BitConverter.GetBytes(1);
            int bytesWritten5;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten5);

            button4.Text = "Loading (6/8)";
            offset = 0x200F28; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = BitConverter.GetBytes(1);
            int bytesWritten6;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten6);

            button4.Text = "Loading (7/8)";
            offset = 0x200F29; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = BitConverter.GetBytes(1);
            int bytesWritten7;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten7);

            button4.Text = "Loading (8/8)";
            offset = 0x200F2A; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = BitConverter.GetBytes(1);
            int bytesWritten8;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten8);
            button4.Text = "Force Hax";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (injected == false)
            {
                MessageBox.Show("Please use the detect client button first!", "HackMee for ClassiCube");
                return;
            }
            
            button5.Text = "Loading (1/8)";
            int offset = 0x1CA37A; // Memory offset from base address
            IntPtr baseAddress = targetProcess.MainModule.BaseAddress;
            IntPtr targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            byte[] buffer = Encoding.UTF8.GetBytes(textBox6.Text);
            int bytesWritten;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);

            button5.Text = "Loading (2/8)";
            offset = 0x1CA5CF; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = Encoding.UTF8.GetBytes(textBox6.Text);
            int bytesWritten2;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten2);

            button5.Text = "Loading (3/8)";
            offset = 0x1CA763; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = Encoding.UTF8.GetBytes(textBox6.Text);
            int bytesWritten3;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten3);

            button5.Text = "Loading (4/8)";
            offset = 0xCA8F7; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = Encoding.UTF8.GetBytes(textBox6.Text);
            int bytesWritten4;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten4);

            button5.Text = "Loading (5/8)";
            offset = 0x1CAA8B; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = Encoding.UTF8.GetBytes(textBox6.Text);
            int bytesWritten5;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten5);

            button5.Text = "Loading (6/8)";
            offset = 0x1CAC1F; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = Encoding.UTF8.GetBytes(textBox6.Text);
            int bytesWritten6;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten6);

            button5.Text = "Loading (7/8)";
            offset = 0x2D4380; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = Encoding.UTF8.GetBytes(textBox6.Text);
            int bytesWritten7;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten7);

            button5.Text = "Loading (8/8)";
            offset = 0x1CADB3; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = Encoding.UTF8.GetBytes(textBox6.Text);
            int bytesWritten8;
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten8);
            button5.Text = "Spoof Client (requires rejoin)";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (injected == false)
            {
                MessageBox.Show("Please use the detect client button first!", "HackMee for ClassiCube");
                return;
            }
            int offset = 0x200F3A; // Memory offset from base address
            IntPtr baseAddress = targetProcess.MainModule.BaseAddress;
            IntPtr targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            byte[] buffer = new byte[4];
            int bytesWritten;
            ReadProcessMemory(hProcess, (IntPtr)0x25D1D7963D4, buffer, buffer.Length, out bytesWritten);
            float FPS = BitConverter.ToSingle(buffer, 0);

            offset = 0x200EC8; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = new byte[4];
            ReadProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);
            float X = BitConverter.ToSingle(buffer, 0);

            offset = 0x200ECC; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = new byte[4];
            ReadProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);
            float Y = BitConverter.ToSingle(buffer, 0);

            offset = 0x200ED0; // Memory offset from base address
            baseAddress = targetProcess.MainModule.BaseAddress;
            targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            buffer = new byte[4];
            ReadProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);
            float Z = BitConverter.ToSingle(buffer, 0);

            MessageBox.Show("FPS: " + FPS + "\nPosition: " + X + ", " + Y + ", " + Z);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (injected == false)
            {
                MessageBox.Show("Please use the detect client button first!", "HackMee for ClassiCube");
                return;
            }
            
            if (PosFly == false)
            {
                PosFly = true;
                Task.Run(async () => await StartFlying());
            }
            else
            {
                PosFly = false;
            }
        }
        private async Task StartFlying()
        {
            while (PosFly == true)
            {
                PosFlyFunction(); // Perform the flying logic
                await Task.Delay(2); // Wait for 500 milliseconds asynchronously
            }
        }
        private void PosFlyFunction()
        {
            int offset = 0x200EC8; // Memory offset from base address
            IntPtr baseAddress = targetProcess.MainModule.BaseAddress;
            IntPtr targetAddress = IntPtr.Add(baseAddress, offset); // Calculate actual address
            byte[] buffer = new byte[4];
            int bytesWritten;
            ReadProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);
            float value = BitConverter.ToSingle(buffer, 0);
            value += 0.3f;
            buffer = BitConverter.GetBytes(value);
            WriteProcessMemory(hProcess, targetAddress, buffer, buffer.Length, out bytesWritten);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
