using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{

    public float moveVelocity = 12 ;
    public float xLimit = 9 ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseHorizontalDirection = Input.GetAxis("Mouse X"); //-1 = esquerda, 0 = parado, 1 = direita
        GetComponent<Transform>().position += Vector3.right * mouseHorizontalDirection * moveVelocity * Time.deltaTime;

        float posXNow= transform.position.x;
        posXNow = Mathf.Clamp (posXNow, -xLimit, xLimit);
        transform.position = new Vector3(posXNow, transform.position.y, transform.position.z);

        if (true)
        {
            
        }
    }
}
