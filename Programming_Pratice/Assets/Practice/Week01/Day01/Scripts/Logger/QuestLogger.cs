using Practice.Week01.Day01.Quest.Base;
using System.IO;
using UnityEngine;

namespace Practice.Week01.Day01.Quest.Logger
{
    public class QuestLogger : MonoBehaviour
    {
        public void Register(IQuest quest) => quest.OnQuestCompleted += SaveToFile;

        private void SaveToFile(IQuest quest)
        {
            File.WriteAllText("QuestLog.txt", $"{quest.QuestName} ¤w§¹¦¨");
            LogUtility.Log($"Quest '{quest.QuestName}' has been completed and logged to file.");
        }
    }
}