using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider))]
public class FindRock : QuestStep
{
    [SerializeField] private TextMeshProUGUI riddle1;
    private Color textColor;
    [SerializeField] private int id;

    private void Start()
    {
        string status = "If hidden plunder be your aim, beneath the rock formation on North East beach ye journey begins";
/*        textColor = riddle1.color;
        textColor.a = 1f;
        riddle1.color = textColor;
        riddle1.text = status;*/
        Debug.Log(status);
        GameEventsManager.instance.riddleUIEvents.RiddleProgress(id, status);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            FinishQuestStep();
        }
    }

    protected void UpdateState()
    {
        // no state is needed for this quest (would require if there was e.g incrementing integer)
    }
    protected override void SetQuestStepState(string state)
    {
        // no state is needed for this quest (would require if there was e.g incrementing integer)
    }
}
