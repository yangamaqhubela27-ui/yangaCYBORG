using System.Diagnostics.Eventing.Reader;

namespace yangaCYBORG_GUI
{
    public partial class Form1 : Form
    {
        private ChatEngine engine = new ChatEngine();
        private List<string> phishingTips = new List<string>()
{
    "Be cautious of emails asking for personal information.",
    "Always check the sender's email address before clicking links.",
    "Do not open suspicious links or attachments from unknown senders."
};
        private string currentTopic = "";
        private string userName = "";
        private string favoriteTopic = "";


        // Stores cybersecurity topics and their responses
        private Dictionary<string, string> cyberResponses =
            new Dictionary<string, string>()
        {
    { "password", "Use strong, unique passwords and never share them." },
    { "scam", "Be careful of suspicious messages and always verify the sender." },
    { "privacy", "Protect your personal information and check your privacy settings." },
    { "phishing", "Avoid suspicious links and never share sensitive information." }
        };





        public Form1()
        {
            InitializeComponent();

            AddMessageBubble(
                "Hello! Welcome to YangaCYBORG, your Cybersecurity Awareness Chatbot!\n\n" +
                "I'm here to help you stay safe online.\n\n" +
                "You can ask me about phishing, scams, passwords, and online privacy.\n\n" +
                "How can I assist you today?",
                false
            );
        }

        // Retrieves a cybersecurity response from the Dictionary
        private string GetCyberResponse(string topic)
        {
            if (cyberResponses.TryGetValue(topic, out string response))
            {
                return response;
            }

            return "I'm not sure I understand. Can you try rephrasing?";
        }

        private void AddMessageBubble(string message, bool isUser)
        {
            Panel messageRow = new Panel();
            messageRow.Width = flowChat.ClientSize.Width - 25;

            Label bubble = new Label();
            bubble.Text = message;
            bubble.Font = new Font("Segoe UI", 11);
            bubble.ForeColor = Color.White;
            bubble.BackColor = isUser
                ? Color.FromArgb(37, 99, 235)
                : Color.FromArgb(51, 65, 85);

            bubble.AutoSize = true;
            bubble.MaximumSize = new Size(
                Math.Max(150, messageRow.Width - 100), 0);
            bubble.Padding = new Padding(12);

            messageRow.Controls.Add(bubble);
            bubble.Location = new Point(
                isUser ? Math.Max(0, messageRow.Width - bubble.Width - 5) : 5,
                5);

            messageRow.Height = bubble.Height + 12;
            messageRow.Margin = new Padding(3, 5, 3, 5);

            messageRow.Width = flowChat.ClientSize.Width - 25;

            flowChat.Controls.Add(messageRow);
            flowChat.ScrollControlIntoView(messageRow);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtUserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userMessage))
            {
                AddMessageBubble(
                    "Please type a message so I can assist you.",
                    false
                );

                txtUserInput.Focus();
                return;
            }

            // Display the user's message
            AddMessageBubble(userMessage, true);

            // Get the chatbot's response from ChatEngine
            string reply = engine.GetResponse(userMessage);

            // Display the chatbot's response
            AddMessageBubble(reply, false);

            // Clear the input box
            txtUserInput.Clear();
            txtUserInput.Focus();
        }


       

           

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
