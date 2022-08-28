using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical_move = Input.GetAxis("Vertical");
        float horizontal_move = Input.GetAxis("Horizontal");

        Vector3 move_vector = new Vector3(horizontal_move, vertical_move, 0);

        transform.Translate(speed * Time.deltaTime * move_vector);
    }
}
