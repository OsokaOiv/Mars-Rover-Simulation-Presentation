using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoSingleton<CameraMovement>
{
    #region Input
    private SimulationControls controls;

    private void Awake()
    {
        controls = new SimulationControls();

        controls.CameraMovementAndRotation.ResetPosition.performed += ctx => ResetPosition();

        controls.CameraMovementAndRotation.Movement.performed += ctx => MovementVector = ctx.ReadValue<Vector2>();
        controls.CameraMovementAndRotation.Movement.canceled += ctx => MovementVector = Vector3.zero;

        controls.CameraMovementAndRotation.Rotation.performed += ctx => RotationVector = ctx.ReadValue<Vector2>();
        controls.CameraMovementAndRotation.Rotation.canceled += ctx => RotationVector = Vector3.zero;
    }

    private void OnEnable()
    {
        controls.CameraMovementAndRotation.Enable();
    }

    private void OnDisable()
    {
        controls.CameraMovementAndRotation.Disable();
    }
    #endregion

    #region Attributes
    [SerializeField] private Transform ResetTransform;
    //[SerializeField] private float MaxVelocity = 20f;
    [SerializeField] private float NormalVelocity = 20f;
    [SerializeField] private float TurnAround = 3f;

    private float Velocity;
    private Vector2 MovementVector;
    private Vector2 RotationVector;

    #endregion

    #region Start and Update
    // Start is called before the first frame update
    void Start()
    {
        Velocity = NormalVelocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //ChangeVelocity();
        Movement();
        Rotation();
    }
    #endregion

    #region Movement Methods
    /*private void ChangeVelocity()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Velocity = MaxVelocity;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Velocity = NormalVelocity;
        }
    }*/

    private void Movement()
    {
        if (MovementVector.y > 0.5f)
        {
            this.gameObject.transform.Translate(Vector3.forward * Velocity * Time.deltaTime);
        }
        else if (MovementVector.y < -0.5f)
        {
            this.gameObject.transform.Translate(Vector3.back * Velocity * Time.deltaTime);
        }

        if (MovementVector.x < -0.5f)
        {
            this.gameObject.transform.Translate(Vector3.left * Velocity * Time.deltaTime);
        }
        else if (MovementVector.x > 0.5f)
        {
            this.gameObject.transform.Translate(Vector3.right * Velocity * Time.deltaTime);
        }
    }

    private void Rotation()
    {
        // transform.eulerAngles += TurnAround * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0); // Rotation with Mouse Position
        transform.eulerAngles += TurnAround * new Vector3(-RotationVector.y, RotationVector.x, 0);
    }

    private void ResetPosition()
    {
        if (ResetTransform != null)
        {
            transform.SetPositionAndRotation(ResetTransform.position, Quaternion.identity);
            Debug.Log("R");
        }
    }
    #endregion
}
