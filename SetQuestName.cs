using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetQuestName : MonoBehaviour
{
    public QuestGiver questGiver;
    public string QuestName = "Quest Name";
    

    public void GetAndSetQuestName(string nameOfQuest)
    {
        QuestName = nameOfQuest;
        QuestName = questGiver.questName;
        
        gameObject.GetComponent<Text>().text = QuestName;
    }
}
