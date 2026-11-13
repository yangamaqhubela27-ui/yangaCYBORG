using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yangaCYBORG_GUI
{
    internal class ChatEngine
    {
        private string userName = "";
        private string favouriteTopic = "";
        private string lastTopic = "";
        private Random rng = new Random();

        private List<string> worriedWords = new List<string>
{
    "worried",
    "scared",
    "afraid",
    "nervous"
};

        private List<string> confusedWords = new List<string>
{
    "confused",
    "lost",
    "don't understand"
};

        private List<string> frustratedWords = new List<string>
{
    "frustrated",
    "angry",
    "annoyed"
};

        private Dictionary<string, string[]> responses =
    new Dictionary<string, string[]>()
{
    { "phishing", new string[]
        {
            "Phishing is when scammers try to steal your personal information.",
            "Avoid clicking suspicious links in emails or messages.",
            "Always verify the sender before sharing personal details."
        }
    },

    { "password", new string[]
        {
            "Use strong passwords with letters, numbers and symbols.",
            "Never share your passwords with anyone.",
            "Use different passwords for different accounts."
        }
    },

    { "privacy", new string[]
        {
            "Avoid sharing personal information online.",
            "Check your social media privacy settings regularly.",
            "Be careful when sharing your location online."
        }
    }
};

        private string DetectSentiment(string message)
        {
            message = message.ToLower();

            foreach (string word in worriedWords)
            {
                if (message.Contains(word))
                {
                    return "worried";
                }
            }

            foreach (string word in confusedWords)
            {
                if (message.Contains(word))
                {
                    return "confused";
                }
            }

            foreach (string word in frustratedWords)
            {
                if (message.Contains(word))
                {
                    return "frustrated";
                }
            }

            return "neutral";
        }


        public string GetResponse(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return "Please type a message so I can help you.";
            }

            string message = userInput.ToLower().Trim();

            // Remember the user's name
            if (message.StartsWith("my name is "))
            {
                userName = userInput.Trim().Substring(11).Trim();

                if (string.IsNullOrWhiteSpace(userName))
                {
                    return "Please tell me your name.";
                }

                return "Nice to meet you, " + userName + "!";
            }

            // Remember when the user expresses interest in a topic
            if (message.StartsWith("i am interested in "))
            {
                favouriteTopic = message.Substring("i am interested in ".Length).Trim();

                if (string.IsNullOrWhiteSpace(favouriteTopic))
                {
                    return "What topic are you interested in?";
                }

                lastTopic = favouriteTopic;

                return "I'll remember that you're interested in " + favouriteTopic + "!";
            }

            // Remember the user's favourite topic
            if (message.StartsWith("my favourite topic is "))
            {
                favouriteTopic = message.Substring("my favourite topic is ".Length).Trim();

                if (string.IsNullOrWhiteSpace(favouriteTopic))
                {
                    return "Please tell me your favourite topic.";
                }

                return "I'll remember that your favourite topic is " +
                       favouriteTopic + ".";
            }

            // Recall the user's name
            if (message.Contains("what is my name"))
            {
                if (string.IsNullOrWhiteSpace(userName))
                    return "You haven't told me your name yet.";

                return "Your name is " + userName + ".";
            }

            // Recall the favourite topic
            if (message.Contains("what is my favourite topic"))
            {
                if (string.IsNullOrWhiteSpace(favouriteTopic))
                    return "You haven't told me your favourite topic yet.";

                return "Your favourite topic is " + favouriteTopic + ".";
            }

            // Check how the user is feeling
            string sentiment = DetectSentiment(message);

            string introduction = "";

            if (sentiment == "worried")
            {
                introduction = "I understand that you're worried. ";
            }
            else if (sentiment == "confused")
            {
                introduction = "Don't worry, I'll explain it simply. ";
            }
            else if (sentiment == "frustrated")
            {
                introduction = "I understand your frustration. ";
            }

            // Check cybersecurity keywords
            foreach (var topic in responses)
            {
                if (message.Contains(topic.Key))
                {
                    lastTopic = topic.Key;

                    string[] answers = topic.Value;

                    int index = rng.Next(answers.Length);

                    return introduction + answers[index];
                }
            }

            // Handle follow-up questions
            if (message.Contains("tell me more") ||
                message.Contains("explain more") ||
                message.Contains("more information"))
            {
                if (!string.IsNullOrEmpty(lastTopic) &&
                    responses.ContainsKey(lastTopic))
                {
                    string[] answers = responses[lastTopic];

                    int index = rng.Next(answers.Length);

                    return introduction + answers[index];
                }

                return "What cybersecurity topic would you like to know more about?";
            }

            // Default response
            return introduction +
                "I'm not sure I understand. You can ask me about phishing, passwords or privacy.";
        }

    }
}
