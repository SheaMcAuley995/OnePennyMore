using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentances;


    void Start()
    {
        sentances = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("AHHHHHHH");

        sentances.Clear();

        foreach(string sentence in dialogue.sentances)
        {
            sentances.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentances.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentance = sentances.Dequeue();
        Debug.Log(sentance);

    }

    void EndDialogue()
    {

    }

}
