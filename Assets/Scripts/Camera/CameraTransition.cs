using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    [SerializeField] private Transform[] views;
    [SerializeField] private float transitionSpeed;
    private Transform currentView;
    public int currentViewIndex = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentViewIndex < views.Length-1)
        {
            currentViewIndex++;
            currentView = views[currentViewIndex];
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && currentViewIndex > 0)
        {
            currentViewIndex--;
            currentView = views[currentViewIndex];
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Lerp position https://youtu.be/EhNzQyGDnHk
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed)
            );

        transform.eulerAngles = currentAngle;
    }
}
