using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// You will need to use Easy Save 3 asset for saving th quest data
public class PlayerQuest : MonoBehaviour
{
    PlayerQuest thisScript;
    public List<Quest> quests = new List<Quest>();
    public QuestGoal questGoal;
    public int experience = 50;
    public int gold = 500;
    public int allQuestsNum;
    
    public int questIndex;
    
     
      public void Start() 
    {
        if (ES3.KeyExists("PlayerQuest"))
        {
            quests = ES3.Load<List<Quest>>("PlayerQuest", quests);
            allQuestsNum =  ES3.Load<int>("QuestsNum", allQuestsNum);
        }
        else
        {
            Debug.Log("Save file doesn't exists");
        }
     
        
    }

    public void OnApplicationQuit() 
    {
        ES3.Save<List<Quest>>("PlayerQuest", quests);
        ES3.Save<int>("QuestsNum", allQuestsNum);
    }

    void Start() 
    {
        thisScript = GetComponent<PlayerQuest>();

        if (ES3.KeyExists("PlayerQuest"))
        {
            thisScript = ES3.Load<PlayerQuest>("PlayerQuest", thisScript);
        }
        else
        {
            Debug.Log("Save file doesn't exists");
        }
    }

    void OnApplicationQuit() 
    {
        ES3.Save<PlayerQuest>("PlayerQuest", thisScript);
    }

    public void GoBattle()
    {
        if (quests.Count !=0 && quests[questIndex].isActive)
        {
            Debug.Log("Now you are doing the quest:" + quests[questIndex].name);
            quests[questIndex].goal.EnemyKilled();
            
            if (quests[questIndex].goal.IsReached())
            {
                experience += quests[questIndex].experienceReward;
                gold += quests[questIndex].goldReward;
               
                quests[questIndex].Complete();
                quests.RemoveAt(questIndex);
                GetPlayerAllQuestsNum();
            }
        }
    }

    public void GetPlayerAllQuestsNum()
    {
       allQuestsNum = quests.Count;
    }
}


