using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    public float speed = 3.0f;
    public bool grounded = true;
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public Transform playerCamera = null;
    [SerializeField] float mouseSensitivity = 5.0f;
    [SerializeField] bool lockCursor = true;

    [SerializeField] float walkSpeed = 3.0f;
    [SerializeField] float jumpSpeed = 4.0f;
    [SerializeField] float gravity = -13.0f;

    [SerializeField] [Range(0.0f, 0.5f)] float moveSmoothTime = 0.01f;
    [SerializeField] [Range(0.0f, 0.5f)] float mouseSmoothTime = 0.03f;

    float cameraPitch = 0.0f;
    CharacterController controller = null;

    float velocityY = 0.0f;

    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelocity = Vector2.zero;

    Vector2 currentMouseDelta = Vector2.zero;
    Vector2 currentMouseDeltaVelocity = Vector2.zero;

    // Audio

    public AudioClip[] FootstepAudioClips;
    public float FootstepAudioVolume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckGrounded();
        Jump();
        UpdateMovement();
    }

    void LateUpdate()
    {
        UpdateMouseLook();
    }

    void CheckGrounded()
    {
        grounded = (transform.position.y < 0.2f) && (transform.position.y > -0.2f);
        anim.SetBool("Grounded", grounded);
    }

    void Jump()
    {
        if (grounded && Input.GetKey("space"))
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
    }

    void UpdateMouseLook()
    {
        Vector2 targetMouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetMouseDelta, ref currentMouseDeltaVelocity, mouseSmoothTime);

        //cameraPitch -= currentMouseDelta.y * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, -90.0f, 90.0f);

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        playerCamera.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    void UpdateMovement()
    {
        float speedMultiplier = 1.0f;
        Vector3 offset; // for camera

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speedMultiplier = 2.0f;
        }
        else
        {
            speedMultiplier = 1.0f;
        }

        if (controller.isGrounded)
        {
            velocityY = 0.0f;
            if (Input.GetKey("space"))
            {
                velocityY = jumpSpeed;
            }
        }

        Vector2 targetDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        targetDir.Normalize();
        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, moveSmoothTime);

        velocityY += gravity * Time.deltaTime;

        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * walkSpeed * speedMultiplier + Vector3.up * velocityY;
        controller.Move(velocity * Time.deltaTime);

        //speed = ((transform.forward * currentDir.y + transform.right * currentDir.x) * walkSpeed * speedMultiplier).magnitude;
        anim.SetFloat("Speed", speed*speedMultiplier);

        // make camera follow the player
        offset = transform.position - playerCamera.transform.position;
        playerCamera.transform.position = transform.position + offset;
    }

    void footstepAudio(AnimationEvent animationEvent)
    {
        var index = Random.Range(0, FootstepAudioClips.Length);
        AudioSource.PlayClipAtPoint(FootstepAudioClips[index], transform.TransformPoint(controller.center), FootstepAudioVolume);
    }
}
