using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAigle : MonoBehaviour
{
    [SerializeField] private float _vitesse = 15;
    private Vector3 Offset = new Vector3(0f, 0f, 20f);

    private int direction = 1;

    void Update()
    {

        if (transform.position.x >= -10)
        {
            direction = -1;
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        else if (transform.position.x <= -50)
        {
            direction = 1;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        transform.position = transform.position + new Vector3(_vitesse * direction * Time.deltaTime, 0f, 0f);





    }
}
