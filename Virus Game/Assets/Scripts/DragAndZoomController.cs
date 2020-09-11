using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndZoomController : MonoBehaviour
{
    Vector3 touchStartPos;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            touchStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 dir = touchStartPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += dir;
        }
        
        if(Camera.main.transform.position.x <= -4.5f)
        {
            Camera.main.transform.position = new Vector3(-4.5f, Camera.main.transform.position.y, Camera.main.transform.position.z);
        } 
        if (Camera.main.transform.position.x >= 4.5f)
        {
            Camera.main.transform.position = new Vector3(4.5f, Camera.main.transform.position.y, Camera.main.transform.position.z);
        }
        if (Camera.main.transform.position.y >= 2.5f)
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, 2.5f, Camera.main.transform.position.z);
        }
        if (Camera.main.transform.position.y <= -2.5f)
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, -2.5f, Camera.main.transform.position.z);
        }
    }
}
