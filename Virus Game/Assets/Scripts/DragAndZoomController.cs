using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndZoomController : MonoBehaviour
{
    Vector3 touchStartPos;

    public float zoomMin = 3.5f;
    public float zoomMax = 7.5f;

    public Transform sc1;
    public Transform sc2;

    public Transform sc3;
    public Transform sc4;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            touchStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float diff = currentMagnitude - prevMagnitude;

            Zoom(diff * 0.01f);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 dir = touchStartPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += dir;
        }

        Zoom(Input.GetAxis("Mouse ScrollWheel"));

        
        if(Camera.main.transform.position.x > sc2.position.x - (((Camera.main.orthographicSize * 2f) * Camera.main.aspect)/2))
        {
            Camera.main.transform.position = new Vector3(sc2.position.x - (((Camera.main.orthographicSize * 2f) * Camera.main.aspect) / 2), Camera.main.transform.position.y, Camera.main.transform.position.z);
        }
        if (Camera.main.transform.position.x < (((Camera.main.orthographicSize * 2f) * Camera.main.aspect) / 2) + sc1.position.x)
        {
            Camera.main.transform.position = new Vector3((((Camera.main.orthographicSize * 2f) * Camera.main.aspect) / 2) + sc1.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
        }

        if (Camera.main.transform.position.y > sc3.position.y - ((Camera.main.orthographicSize * 2f)/ 2))
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, sc3.position.y - ((Camera.main.orthographicSize * 2f) / 2), Camera.main.transform.position.z);
        }
        if (Camera.main.transform.position.y < ((Camera.main.orthographicSize * 2f) / 2) + sc4.position.y )
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, ((Camera.main.orthographicSize * 2f) / 2) + sc4.position.y, Camera.main.transform.position.z);
        }


    }

    public void Zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomMin, zoomMax);
    }
}
