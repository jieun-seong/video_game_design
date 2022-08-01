using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public bool inTutorial = true;
    public GameObject player;
    public Canvas dialogueCanvas;
    public Quest quest;
    [SerializeField] private DialogueObject tutorialE;
    [SerializeField] private DialogueObject tutorialQ;
    [SerializeField] private DialogueObject tutorialV;
    [SerializeField] private DialogueObject tutorialSpace;
    [SerializeField] private DialogueObject beginGame;
    private DialogueUI dialogueui;
    // Start is called before the first frame update
    void Start()
    {
        dialogueui = dialogueCanvas.GetComponent<DialogueUI>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) {
            EndTutorial();
        }
        GameObject interactionSpot = GameObject.Find("InteractionSpot");
        float distance = Vector3.Distance(player.transform.position, interactionSpot.transform.position);
        if (Input.GetKeyDown(KeyCode.E) && distance < 5) {
            dialogueui.ShowDialogue(tutorialE);
        }
        GameObject pressQ = GameObject.Find("PressQCanvas");
        distance = Vector3.Distance(player.transform.position, pressQ.transform.position);
        if (Input.GetKeyDown(KeyCode.Alpha1) && distance < 10) {
            dialogueui.ShowDialogue(tutorialQ);
        }
        GameObject pressV = GameObject.Find("PressVCanvas");
        distance = Vector3.Distance(player.transform.position, pressV.transform.position);
        if (Input.GetKeyDown(KeyCode.Alpha2) && distance < 10) {
            dialogueui.ShowDialogue(tutorialV);
        }
        GameObject pressSpace = GameObject.Find("PressSpaceCanvas");
        distance = Vector3.Distance(player.transform.position, pressSpace.transform.position);
        if (Input.GetKeyDown(KeyCode.Space) && distance < 10) {
            dialogueui.ShowDialogue(tutorialSpace);
        }
    }

    public void EndTutorial() {
        quest.ChangeQuest("Find your friends",1, new Vector3(5195, 39, 5240));
        GameObject tutorial = GameObject.Find("Tutorial");
        inTutorial = false;
        dialogueui.ShowDialogue(beginGame);
        Destroy(tutorial);
    }
}
