using Practice.Week01.Day01.Quest;
using Practice.Week01.Day01.Quest.Logger;
using UnityEngine;

namespace Practice.Week01.Day01.Scripts.Quest.Manager
{
    public class QuestManager : MonoBehaviour
    {
        [SerializeField] private QuestLogger questLogger;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            var basicQuest = new BasicQuest("First Quest");
            questLogger.Register(basicQuest);

            basicQuest.CompleteQuest();
        }
    }
}

