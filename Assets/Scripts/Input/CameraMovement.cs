using System.Diagnostics;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float dragSpeed = 55;
    private Vector3 dragOrigin;
 
 
    void Update()
    {
        float speed = dragSpeed * Time.deltaTime;
        
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }
 
        if (!Input.GetMouseButton(0)) return;
 
        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * speed, pos.y * speed, 0);
 
        transform.Translate(move, Space.World);  
    }
}