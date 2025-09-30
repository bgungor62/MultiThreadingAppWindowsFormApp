namespace MultiThreadingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LogManager.Default.OnLogAdded += (s, e) => { AddLog(e); };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void AddLog(string message)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action(() => AddLog(message)));
                return;
            }
            message = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss:fff}]-{message}";
            listBox1.Items.Add(message);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
