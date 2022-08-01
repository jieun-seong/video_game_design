using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class NPCAI : MonoBehaviour
{
    [SerializeField] private GameStatus gameStatus;
    private UnityEngine.AI.NavMeshAgent agent;
    private Animator anim;
    public GameObject player;
    public GameObject[] friends;
    public GameObject lookAtWaypoint;
    public GameObject endingWaypoint;
    public Canvas dialogueCanvas;
    [SerializeField] private DialogueObject friendDialogue;
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private DialogueObject endingDialogue;
    public GameObject[] waypoints;
    public int currWaypoint = -1;
    private float standingTime = 0f;
    public bool hasArrived = false;
    private bool talking = false;
    private bool talking2 = false;
    private DialogueUI dialogueui;
    private bool check = true;
    private bool check2 = true;
    public Quest quest;
    public GameObject billy;

    public enum AIState {
        meetFriends,
        walkAround, 
        stand,
        talkToFriends,
        safe,
    };

    public AIState aiState;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        dialogueui = dialogueCanvas.GetComponent<DialogueUI>();
        agent.speed = 0.5f;
        anim = GetComponent<Animator>();
        aiState = AIState.meetFriends;
        anim.SetFloat("Blend", 1f);
        setNextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        switch (aiState) {
            case AIState.meetFriends:
                if (agent.remainingDistance < 1 && !agent.pathPending) {
                    hasArrived = true;
                    aiState = AIState.talkToFriends;
                    transform.LookAt(lookAtWaypoint.transform.position, lookAtWaypoint.transform.up);
                }
            break;
            case AIState.walkAround:
                if (agent.remainingDistance < 1 && !agent.pathPending) {
                    aiState = AIState.stand;
                    standingTime = Time.time;
                    anim.SetFloat("Blend", 0f);
                }
                if (quest.questString == "Clear out the zombies.") {
                    aiState = AIState.safe;
                }
            break;
            case AIState.stand:
                if (standingTime + 5 < Time.time) {
                    aiState = AIState.walkAround;
                    anim.SetFloat("Blend", 1f);
                    setNextWaypoint();
                }
                if (quest.questString == "Clear out the zombies.") {
                    aiState = AIState.safe;
                }
            break;
            case AIState.talkToFriends:
                anim.SetFloat("Blend", 0f);
                Vector3 targetDirection = player.transform.position - transform.position;
                transform.forward = Vector3.Slerp(transform.forward, new Vector3(targetDirection.x, 0.0f, targetDirection.z), 0.03f); // look at player
                if (talking) { //player has already clicked E
                    if (transform.name == "Break" && check) { //show dialogue once
                        dialogueui.ShowDialogue(friendDialogue);
                    }
                    check = false; // only show dialogue once
                    if (!dialogueBox.active) {
                        aiState = AIState.walkAround;
                        anim.SetFloat("Blend", 1f);
                        talking = false;
                        quest.ChangeQuest("Find Billy", 2, new Vector3(5101, 47, 5291));
                        billy.SetActive(true);
                        setNextWaypoint();
                    }
                } else { // player needs to click E still
                    if (Input.GetKey(KeyCode.E) && Vector3.Distance(player.transform.position, lookAtWaypoint.transform.position) < 5) {
                        standingTime = Time.time;
                        talking = true;
                    }
                }
            break;
            case AIState.safe:
                anim.SetFloat("Blend", 0f);
                targetDirection = player.transform.position - transform.position;
                transform.forward = Vector3.Slerp(transform.forward, new Vector3(targetDirection.x, 0.0f, targetDirection.z), 0.03f); 
                if (transform.name == "Break") {
                    this.transform.position = new Vector3(5177, (float)39.2, 4935);
                } else if (transform.name == "Ches") {
                    this.transform.position = new Vector3(5173, (float)40.3, 4939);
                } else if (transform.name == "March") {
                    this.transform.position = new Vector3(5177, (float)39.2, 4944);
                }
                if (talking2) { //player has already clicked E
                    if (transform.name == "Break" && check2) { //show dialogue once
                        dialogueui.ShowDialogue(endingDialogue);
                    }
                    check2 = false; // only show dialogue once
                    if (!dialogueBox.active) {
                        gameStatus.playerWon = true;
                    }
                } else { // player needs to click E still
                    if (Input.GetKey(KeyCode.E) && Vector3.Distance(player.transform.position, endingWaypoint.transform.position) < 5) {
                        talking2 = true;
                    }
                }
            break;
        }
    }

    private void setNextWaypoint() {
        if (waypoints.Length == 0) {
            throw new System.IndexOutOfRangeException("Waypoints array is empty");
        } else {
            currWaypoint = (currWaypoint + 1) % waypoints.Length;
            agent.SetDestination(waypoints[currWaypoint].transform.position);
        }
    }
}
