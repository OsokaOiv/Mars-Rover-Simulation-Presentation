using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RoverController : MonoBehaviour
{
    #region Input
    private PresentationControls controls;
    private void Awake()
    {
        controls = new PresentationControls();

        controls.LagDemo.ForwardWithLag.performed += ctx => StartCoroutine(MoveForwardRoutine());
    }

    IEnumerator MoveForwardRoutine()
    {
        yield return new WaitForSeconds(3);
        DistanceToDrive = 1;
    }

    private void OnEnable()
    {
        controls.LagDemo.Enable();
    }

    private void OnDisable()
    {
        controls.LagDemo.Disable();
    }
    #endregion

    #region Attribute
    public int TimeMultiplier = 100; // Zeitmultiplikator
    [SerializeField] private LayerMask GroundLayer;
    private const float MovementSpeed = .0067f; // 0,67 cm/s
    private const float RoverHeightAboveGround = .05f;
    private float DistanceToDrive = 0;
    #endregion
    // Wird zur Initialisierung aufgerufen
    private void Start()
    {
        ParallelToGround(); // Rover parallel zum Boden orientieren
    }

    // Die Kontrollschleife wird wiederholt aufgerufen
    private void Update()
    {
        if (DistanceToDrive > 0)
        { // Wenn er fahren kann
            MoveForward(); // Vorwärts fahren
            ParallelToGround();
        }
    }

    #region Bewegung und Rotation zum Wegpunkt
    // Bewegt den Rover nach vorne
    private void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * TimeMultiplier * MovementSpeed);
        DistanceToDrive -= Time.deltaTime * TimeMultiplier * MovementSpeed;
    }

    // Rotiert den Rover parallel zum Boden
    private void ParallelToGround()
    {
        Ray ray = new Ray(transform.position, Vector3.down); // Checkt den Boden direkt unter dem Rover mit einem Ray
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, GroundLayer))
        {
            transform.position = new Vector3(transform.position.x, raycastHit.point.y + RoverHeightAboveGround, transform.position.z);
            transform.rotation = Quaternion.FromToRotation(transform.up, raycastHit.normal) * transform.rotation; // Parallel zum Boden
        }
    }
    #endregion
}
