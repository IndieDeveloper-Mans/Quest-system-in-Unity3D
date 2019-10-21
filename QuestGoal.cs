using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    GoalType goalType;
    
    public int requiredAmmount;
    public int currentAmmount;

    public bool IsReached()
    {   
        return (currentAmmount >= requiredAmmount);
    }

    public void EnemyKilled()
    {
        if (goalType == GoalType.Kill)
        {
            currentAmmount++;
        }
    }

    public void ItemCollected()
    {
        if (goalType == GoalType.Gathering)
        {
            currentAmmount++;
        }
    }
}

public enum GoalType
{
    Kill,
    Gathering
}