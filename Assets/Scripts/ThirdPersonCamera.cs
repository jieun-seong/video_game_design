using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour
{
    public float positionSmoothTime = 10f;		// a public variable to adjust smoothing of camera motion
    public float rotationSmoothTime = 10f;
    public float positionMaxSpeed = 70f;        //max speed camera can move
    public float rotationMaxSpeed = 70f;
    public Transform desiredPosition;			// the desired pose for the camera, specified by a transform in the game
    public Transform target;
    public float cameraDistance = 2.0f;

    protected Vector3 currentPositionCorrectionVelocity;
    //protected Vector3 currentFacingCorrectionVelocity;
    //protected float currentFacingAngleCorrVel;
    protected Quaternion quaternionDeriv;

    protected float angle;

    void LateUpdate()
    {
        //transform.position = target.transform.position - target.transform.forward * cameraDistance;
        desiredPosition.position = target.transform.position - target.transform.forward * cameraDistance;
        //transform.LookAt(target.transform.position);
        //transform.position = new Vector3(transform.position.x, transform.position.y + 2.0f, transform.position.z);

        //transform.position = target.transform.position - target.transform.forward * cameraDistance;
        //transform.LookAt(target.transform.position);
        //transform.position = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);


        float rotationSpeed = 4f;
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = -Input.GetAxis("Mouse Y");

        transform.RotateAround(target.position, Vector3.up, rotateHorizontal * rotationSpeed);
        transform.RotateAround(target.position, this.transform.right, rotateVertical * rotationSpeed);

        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition.position, ref currentPositionCorrectionVelocity, positionSmoothTime, positionMaxSpeed, Time.deltaTime);

        //var targForward = desiredPosition.forward;
        //var targForward = target.forward;
        var targForward = (target.position - this.transform.position).normalized;

        transform.rotation = QuaternionUtil.SmoothDamp(transform.rotation,
            Quaternion.LookRotation(targForward, Vector3.up), ref quaternionDeriv, rotationSmoothTime);

    }
}
