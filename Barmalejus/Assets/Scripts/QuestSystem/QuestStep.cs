using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class QuestStep : MonoBehaviour
{
    private bool isFinished = false;

    // Quest step needs to know which quest it is part of
    private string questId;

    public void InitializeQuestStep(string questId)
    {
        this.questId = questId;
    }

    protected void FinishQuestStep()
    {
        if(!isFinished)
        {
            isFinished = true;

            GameEventsManager.instance.questEvents.AdvanceQuest(questId);

            Destroy(this.gameObject);
        }
    }
}