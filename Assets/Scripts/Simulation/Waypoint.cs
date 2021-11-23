using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Waypoint : MonoSingleton<Waypoint>
{
    #region Input
    private SimulationControls controls;

    public override void Init()
    {
        controls = new SimulationControls();

        controls.WaypointSetting.SetWaypoint.performed += ctx => SetWaypoint();
        controls.WaypointSetting.RemoveWaypoint.performed += ctx => RemoveWaypoint();
    }

    private void OnEnable()
    {
        controls.WaypointSetting.Enable();
    }

    private void OnDisable()
    {
        controls.WaypointSetting.Disable();
    }
    #endregion

    #region Attributes
    [SerializeField] private RectTransform WaypointTransform;
    [SerializeField] private Transform Rover;
    [SerializeField] private LayerMask GroundLayer;
    [SerializeField] private Text distanceText;
    public Queue<Vector3> Waypoints = new Queue<Vector3>();
    #endregion

    private void Start()
    {
        //Waypoints.Enqueue(new Vector3(-111.5f, 33.1f, 135.6f));
        Waypoints.Enqueue(new Vector3(-107f, 32.3f, 155.3f));
        Waypoints.Enqueue(new Vector3(-118.2f, 31.8f, 170.6f));
        Waypoints.Enqueue(new Vector3(-93.3f, 34.8f, 147f));
        Waypoints.Enqueue(new Vector3(-110.8f, 32.1f, 153.3f));
        //Waypoints.Enqueue(new Vector3(-111.5f, 33.1f, 135.6f));
        Waypoints.Enqueue(new Vector3(-94.9f, 37.2f, 128.3f));
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            GetMouse3DPosition();
        }*/

        WaypointTransform.gameObject.SetActive(Waypoints.Count > 0);

        if (Waypoints.Count > 0)
            DisplayArrowOnWaypoint();

    }

    #region Waypoint Methods
    private void GetMouse3DPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, GroundLayer))
        {
            Waypoints.Enqueue(raycastHit.point);
        }
    }

    private void SetWaypoint()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, GroundLayer))
        {
            Waypoints.Enqueue(raycastHit.point);
        }
    }

    private void RemoveWaypoint()
    {
        if (Waypoints.Count > 0)
        {
            Waypoints.Dequeue();
        }
    }

    private void DisplayArrowOnWaypoint()
    {
        var screenPos = Camera.main.WorldToScreenPoint(Waypoints.Peek());
        WaypointTransform.position = screenPos;
        WaypointTransform.gameObject.SetActive(screenPos.z > 0);
        distanceText.text = Vector3.Distance(Rover.position, Waypoints.Peek()).ToString("0.0") + " m";
    }
    #endregion
}
