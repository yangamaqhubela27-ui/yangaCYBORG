using System.Diagnostics.Eventing.Reader;

namespace yangaCYBORG_GUI
{
    public partial class Form1 : Form
    {
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
            string message = userMessage.ToLower();

            if (string.IsNullOrWhiteSpace(userMessage))
            {
                AddMessageBubble(
                    "Please type a message so I can assist you.",
                    false
                );
                txtUserInput.Focus();
                return;
            }

            AddMessageBubble(userMessage, true);


            if (message.StartsWith("my name is "))
            {
                userName = userMessage.Substring(11).Trim();

                AddMessageBubble(
                    "Nice to meet you, " + userName + "! 💙 " +
                    "I'm YangaCYBORG, your cybersecurity assistant. " +
                    "What would you like to learn about today?",
                    false
                );
            }


            else if (
    message == "hi" ||
    message == "hello" ||
    message == "hey" ||
    message == "hii" ||
    message == "heyy" ||
    message == "good morning" ||
    message == "good afternoon" ||
    message == "good evening" ||
    message == "how are you" ||
    message == "how are you?")
            {
                if (string.IsNullOrWhiteSpace(userName))
                {
                    AddMessageBubble(
                        "Hello there! 💙 I'm YangaCYBORG, " +
                        "your cybersecurity awareness assistant. " +
                        "It's lovely to meet you! " +
                        "What's your name?",
                        false
                    );
                }
                else
                {
                    AddMessageBubble(
                        "Hello again, " + userName + "! 💙 " +
                        "It's great to have you here. " +
                        "Would you like to learn about phishing, " +
                        "scams, passwords, or online privacy?",
                        false
                    );
                }
            }


            else if (message.StartsWith("i'm interested in ") ||
                     message.StartsWith("i am interested in "))
            {
                string phrase = message.StartsWith("i'm interested in ")
                    ? "i'm interested in "
                    : "i am interested in ";

                favoriteTopic = userMessage.Trim()
                    .Substring(phrase.Length).Trim();


                AddMessageBubble(
                     "I'll remember that you're interested in " +
                    favoriteTopic + ".",
                   false
                 );

            }
            else if (message.Contains("what is my name") ||
                     message.Contains("what's my name"))
            {

                AddMessageBubble(
                  userName == ""
                 ? "You haven't told me your name yet."
                 : "Your name is " + userName + ".",
                     false
                 );



            }
            else if (message.Contains("my favourite topic") ||
                     message.Contains("my favorite topic"))
            {
                AddMessageBubble(
                favoriteTopic == ""
                 ? "You haven't told me your favourite topic yet."
                 : "Your favourite topic is " + favoriteTopic + ".",
                     false
                       );
            }

            else if (message.Contains("worried") ||
         message.Contains("scared") ||
         message.Contains("frustrated") ||
         message.Contains("curious"))
            {
                string topic = "";

                if (message.Contains("scam"))
                    topic = "scam";
                else if (message.Contains("phishing"))
                    topic = "phishing";
                else if (message.Contains("password"))
                    topic = "password";
                else if (message.Contains("privacy"))
                    topic = "privacy";
                else
                    topic = currentTopic;

                if (message.Contains("worried") || message.Contains("scared"))
                {

                    AddMessageBubble(
                       "It's understandable to feel worried. " +
                       "I'm here to help you stay safe.",
                           false
                     );

                }
                else if (message.Contains("frustrated"))
                {

                    AddMessageBubble(
                          "I understand that cybersecurity can feel frustrating. " +
                      "Let's work through it together.",
                         false
                     );

                }
                else
                {
                    AddMessageBubble(
                     "It's great that you're curious! " +
                     "Learning about cybersecurity helps you stay protected.",
                         false
                         );
                     }

                if (topic == "scam")
                {
                    AddMessageBubble(GetCyberResponse("scam"), false);
                }

                else if (topic == "phishing")
                {
                    AddMessageBubble(GetCyberResponse("phishing"), false);
                }



                else if (topic == "password")
                {
                    AddMessageBubble(GetCyberResponse("password"), false);
                }




                else if (topic == "privacy")
                {
                    AddMessageBubble(GetCyberResponse("privacy"), false);
                }



                else
                    {
                        AddMessageBubble(
                            "Would you like to learn about scams, phishing, passwords or privacy?",
                            false
                        );
                    }
                

                currentTopic = topic;
            }

            else if (userMessage.ToLower().Contains("password"))
                
            {
                currentTopic = "password";

                AddMessageBubble(
                  "Use strong, unique passwords for each account and avoid using personal information in your passwords.",
                   false
 );

            }
            else if (userMessage.ToLower().Contains("scam"))
            {
                currentTopic = "scam";

                AddMessageBubble(
    "Be careful of suspicious messages, links, or requests for personal information.",
    false
);


            }
            else if (userMessage.ToLower().Contains("privacy"))
            {
                currentTopic = "privacy";

                AddMessageBubble(
       "Protect your privacy by limiting the personal information you share online.",
       false
   );

            }
            else if (userMessage.ToLower().Contains("phishing"))
            {
                currentTopic = "phishing";

                Random random = new Random();
                int index = random.Next(phishingTips.Count);

                AddMessageBubble(phishingTips[index], false);
            }

            else if (userMessage.ToLower().Contains("another tip") && currentTopic == "phishing")
            {
                Random random = new Random();
                int index = random.Next(phishingTips.Count);

                AddMessageBubble(phishingTips[index], false);
            }

            else if (message.Contains("explain more") ||
         message.Contains("tell me more") ||
         message.Contains("i don't understand")||
         message.Contains("i dont understand"))
            {
                if (currentTopic == "password")
                {
                    AddMessageBubble(
      "A strong password should be long, unique, and difficult to guess. Consider using a password manager.",
      false
  );
                }
                else if (currentTopic == "scam")
                {
                    AddMessageBubble(
      "Scammers often pretend to be trusted organisations. Always verify messages before responding.",
      false
  );
                }
                else if (currentTopic == "privacy")
                {

                    AddMessageBubble(
    "Avoid sharing sensitive information online and review your social media privacy settings.",
    false
);

                }
                else if (currentTopic == "phishing")
                {

                    AddMessageBubble(
    "Phishing is when criminals use fake messages or websites to trick you into revealing personal information.",
    false
);

                }
                else
                {

                    AddMessageBubble(
    "Please ask me about passwords, scams, privacy, or phishing first.",
    false
);

                }
            }

            else
            {

                AddMessageBubble(
    "I am not sure about that yet. Try asking me about passwords, scams, privacy, or phishing.",
    false
);

            }

            txtUserInput.Clear();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
