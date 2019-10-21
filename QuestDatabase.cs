using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "QuestDatabase")]
public class QuestDatabase : ScriptableObject
{
   public List<Quest> quests = new List<Quest>();
   
}
