using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class NPCAI : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    private Animator anim;
    public GameObject player;
    public GameObject[] friends;
    public GameObject lookAtWaypoint;
    public Canvas dialogueCanvas;
    [SerializeField] private DialogueObject friendDialogue;
    public GameObject[] waypoints;
    public int currWaypoint = -1;
    private float standingTime = 0f;
    public bool hasArrived = false;
    private bool talking = false;
    private DialogueUI dialogueui;
    private bool check = true;

    public enum AIState {
        meetFriends,
        walkAround, 
        stand,
        talkToFriends,
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
                if (agent.remainingDistance == 0 && !agent.pathPending) {
                    aiState = AIState.stand;
                    standingTime = Time.time;
                    anim.SetFloat("Blend", 0f);
                }
            break;
            case AIState.stand:
                if (standingTime + 5 < Time.time) {
                    aiState = AIState.walkAround;
                    anim.SetFloat("Blend", 1f);
                    setNextWaypoint();
                }
            break;
            case AIState.talkToFriends:
                anim.SetFloat("Blend", 0f);
                if (talking) {
                    if (transform.name == "Break" && check) {
                        dialogueui.ShowDialogue(friendDialogue);
                    }
                    check = false; //only show dialogue once
                    if (standingTime + 25 < Time.time) {
                        aiState = AIState.walkAround;
                        anim.SetFloat("Blend", 1f);
                        talking = false;
                        setNextWaypoint();
                    }
                } else {
                    if (Input.GetKey(KeyCode.E) && Vector3.Distance(player.transform.position, lookAtWaypoint.transform.position) < 5) {
                        standingTime = Time.time;
                        talking = true;
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
