using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraTransition : MonoBehaviour
{
    #region Input
    private PresentationControls controls;

    private void Awake()
    {
        controls = new PresentationControls();

        controls.ViewTransitions.NextView.performed += ctx => NextView();
        controls.ViewTransitions.PreviousView.performed += ctx => PreviousView();
    }

    private void OnEnable()
    {
        controls.ViewTransitions.Enable();
    }

    private void OnDisable()
    {
        controls.ViewTransitions.Disable();
    }
    #endregion

    [SerializeField] private Transform[] views;
    [SerializeField] private float transitionSpeed = 7.5f;
    private Transform currentView;
    private int currentViewIndex = 0;
    private float lerpBorder = 0.01f;

    private void Start()
    {
        currentView = views.Length != 0 ? views[currentViewIndex] : transform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (currentView.position.x < transform.position.x - lerpBorder || currentView.position.x > transform.position.x + lerpBorder || 
            currentView.position.y < transform.position.y - lerpBorder || currentView.position.y > transform.position.y + lerpBorder || 
            currentView.position.z < transform.position.z - lerpBorder || currentView.position.x > transform.position.x + lerpBorder)
        {
            // Lerp position https://youtu.be/EhNzQyGDnHk
            transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

            Vector3 currentAngle = new Vector3(
                Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
                Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
                Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed)
                );

            transform.eulerAngles = currentAngle;
        }
    }

    private void NextView()
    {
        if (currentViewIndex < views.Length - 1)
        {
            currentView.gameObject.SetActive(false);
            currentViewIndex++;
            currentView = views[currentViewIndex];
            currentView.gameObject.SetActive(true);
        }
    }

    private void PreviousView()
    {
        if (currentViewIndex > 0)
        {
            currentView.gameObject.SetActive(false);
            currentViewIndex--;
            currentView = views[currentViewIndex];
            currentView.gameObject.SetActive(true);
        }
    }
}
