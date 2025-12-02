using System.Collections.ObjectModel;

namespace Ride;

    public class ConversationItem
    {
        public string AvatarUrl { get; set; } = "dotnet_bot.png";
        public string ContactName { get; set; }
        public string LastMessage { get; set; }
        public string TimeAgo { get; set; }
    }

    public class MensajesViewModel
    {
        public ObservableCollection<ConversationItem> Conversations { get; } = new();

        public MensajesViewModel()
        {
            Conversations.Add(new ConversationItem { ContactName = "Jane D", LastMessage = "Hey, are you still on for the morning?", TimeAgo = "2h" });
            Conversations.Add(new ConversationItem { ContactName = "Mark", LastMessage = "Listo para salir.", TimeAgo = "1d" });
        }
    }
