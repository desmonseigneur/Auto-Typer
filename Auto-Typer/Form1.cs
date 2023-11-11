namespace Auto_Typer
{
    public partial class Form1 : Form
    {
        private bool stop;
        private string inputText;

        public Form1()
        {
            InitializeComponent();
        }

        private void Type_Click(object sender, EventArgs e)
        {
            stop = false;
            int interval = int.Parse(TB001.Text);
            inputText = TB002.Text;
            Thread typingThread = new Thread(AutoType);
            typingThread.Start(interval);
        }

        private void AutoType(object intervalObj)
        {
            int interval = (int)intervalObj;

            while (!stop)
            {
                string currentText = GetCurrentText();
                if (currentText != inputText)
                {
                    SendKeys.SendWait("no");
                }

                SendKeys.SendWait(inputText);
                Thread.Sleep(interval * 1000);
            }
        }

        private string GetCurrentText()
        {
            // Replace this with your own logic to get the current text from your application.
            // For example, if you are using a chat application like Messenger, you can retrieve the chat input.

            // Assuming you have a TextBox control for the chat input, you can check if it ends with "m":
            string chatInput = TB003.Text.Trim(); // Trim whitespace at the beginning and end

            if (chatInput.EndsWith("m", StringComparison.OrdinalIgnoreCase))
            {
                // Automatically type "no" if the chat input ends with "m"
                SendKeys.SendWait("no");
            }

            return chatInput;
        }


        private void Stop_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
}
