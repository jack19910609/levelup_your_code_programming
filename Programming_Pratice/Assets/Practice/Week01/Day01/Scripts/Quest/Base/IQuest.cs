using System;

namespace Practice.Week01.Day01.Quest.Base
{
    public interface IQuest
    {
        string QuestName { get; }
        bool IsCompleted { get; }

        event Action<IQuest> OnQuestCompleted;

        void CompleteQuest();
    }
}

