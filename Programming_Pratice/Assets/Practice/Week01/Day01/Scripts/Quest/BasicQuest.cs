using Practice.Week01.Day01.Quest.Base;
using System;

namespace Practice.Week01.Day01.Quest
{
    public class BasicQuest : IQuest
    {
        public string QuestName { get; private set; }
        public bool IsCompleted { get; private set; }

        public event Action<IQuest> OnQuestCompleted;

        public BasicQuest(string questName)
        {
            QuestName = questName;
            IsCompleted = false;
        }

        public void CompleteQuest()
        {
            if (!IsCompleted)
            {
                IsCompleted = true;
                OnQuestCompleted?.Invoke(this);
            }
        }
    }
}

