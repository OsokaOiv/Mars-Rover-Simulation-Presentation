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

        controls.CameraMovementAndRotation.Up.performed += ctx => MovementVector.z = 1;
        controls.CameraMovementAndRotation.Up.canceled += ctx => MovementVector.z = 0;
        controls.CameraMovementAndRotation.Down.performed += ctx => MovementVector.z = -1;
        controls.CameraMovementAndRotation.Down.canceled += ctx => MovementVector.z = 0;
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
    [SerializeField] private Transform parentTransform;
    [SerializeField] private float NormalVelocity = 20f;
    [SerializeField] private float TurnAround = 150f;

    private float Velocity;
    private Vector3 MovementVector;
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
        Movement();
        Rotation();
    }
    #endregion

    #region Movement Methods

    private void Movement()
    {
        if (MovementVector.y > 0.5f)
        {
            parentTransform.Translate(Vector3.forward * Velocity * Time.deltaTime);
        }
        else if (MovementVector.y < -0.5f)
        {
            parentTransform.Translate(Vector3.back * Velocity * Time.deltaTime);
        }

        if (MovementVector.x < -0.5f)
        {
            parentTransform.Translate(Vector3.left * Velocity * Time.deltaTime);
        }
        else if (MovementVector.x > 0.5f)
        {
            parentTransform.Translate(Vector3.right * Velocity * Time.deltaTime);
        }

        if (MovementVector.z > 0.5f)
        {
            parentTransform.Translate(Vector3.up * Velocity * Time.deltaTime);
        }
        else if (MovementVector.z < -0.5f)
        {
            parentTransform.Translate(Vector3.down * Velocity * Time.deltaTime);
        }
    }

    private void Rotation()
    {
        transform.Rotate(-RotationVector.y * TurnAround * Time.deltaTime, 0, 0);
        parentTransform.Rotate(0, RotationVector.x * TurnAround * Time.deltaTime, 0);
    }

    private void ResetPosition()
    {
        if (ResetTransform != null)
        {
            parentTransform.SetPositionAndRotation(ResetTransform.position, Quaternion.identity);
            Debug.Log("R");
        }
    }
    #endregion
}
