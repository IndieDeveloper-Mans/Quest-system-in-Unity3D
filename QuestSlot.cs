using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestSlot : MonoBehaviour
{
 public QuestSlot questSlot;
 public Quest questInfo;
 public QuestGiver questGiver;
 public Text questName;
 public string questIsActive;
 public string QuestName;
 public Button myBtn;
    
    #if UNITY_EDITOR
    public void OnValidate() 
    {
        QuestName = gameObject.GetComponent<QuestSlot>().questInfo.name;
        myBtn = gameObject.GetComponent<Button>();
        questName.text = QuestName;
    }
    #endif

    public void GetQuestName()
    {
        QuestName = gameObject.GetComponent<QuestSlot>().questInfo.name;
        questName.text = QuestName;
        questGiver.ShowQuestInfo(QuestName);
        questGiver.GetQuestStatus();
    }
} 

