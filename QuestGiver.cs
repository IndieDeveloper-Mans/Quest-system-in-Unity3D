using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
   public QuestDatabase questDatabase;
   public PlayerQuest playerQuest;
   public Text questStatus;
   public Text titleText;
   public Text descriptionText;
   public Text experienceText;
   public Text goldText;
   public Image questImage; 
   public int questInd;
   public string nameOfQuest;
   public int choosenQuestID;
   
   void Start()
   {
       if (playerQuest == null)
       {
           playerQuest = GameObject.FindObjectOfType<PlayerQuest>();
       }
   }
   public void ShowQuestInfo(string nameOfQuest)
   {  
       questInd = questDatabase.quests.FindIndex(quest => quest.name == nameOfQuest);
   
       titleText.text = questDatabase.quests[questInd].title;
       descriptionText.text = questDatabase.quests[questInd].description;
       experienceText.text = questDatabase.quests[questInd].experienceReward.ToString();
       goldText.text = questDatabase.quests[questInd].goldReward.ToString(); 
       questImage.sprite = questDatabase.quests[questInd].questIcon;
       Debug.Log(nameOfQuest);      
   }

    public void AcceptQuest()
    {
        if (playerQuest.quests.Contains(questDatabase.quests[questInd]))
        {
            Debug.Log("You already started this quest");
        }
        else
        {
            questDatabase.quests[questInd].isActive = true;
            playerQuest.quests.Add(this.questDatabase.quests[questInd]);   
            playerQuest.GetPlayerAllQuestsNum();
            GetQuestStatus();
        }
    }
    public void GetQuestStatus()
    {
        if (questDatabase.quests[questInd].isActive == true)
        {
            questStatus.text = "Active";
        }
        else
        {
            questStatus.text = "No active";
        }
    }
}
