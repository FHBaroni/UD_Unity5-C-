using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeArestas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main;
        EdgeCollider2D collider = GetComponent<EdgeCollider2D>();
        Vector2 bottomLeftCorner = cam.ScreenToWorldPoint(new Vector3(0,0,0));
        Vector2 topLeftCorner = cam.ScreenToWorldPoint(new Vector3(0,Screen.height,0));
        Vector2 topRightCorner = cam.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));
        Vector2 bottomRightCorner = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
        collider.points = new Vector2[5] {topLeftCorner, bottomLeftCorner, bottomRightCorner, topRightCorner, topLeftCorner };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
