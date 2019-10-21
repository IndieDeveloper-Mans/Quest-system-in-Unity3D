using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "Quest")]

[Serializable]
public class Quest : ScriptableObject
{
  public Sprite questIcon;
  public bool isActive;
  public string title;
  public string description;
  public int experienceReward;
  public int goldReward;

  public QuestGoal goal;

  public void Complete()
  {
      isActive = false;
      goal.currentAmmount = 0;
      Debug.Log(title + "was completed");
  }
}
