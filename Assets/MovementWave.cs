using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWave : MonoBehaviour
{
    public Vector3 speed;
    public float golfSterkte;
    public float golfFrequentie;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position = position + speed * Time.deltaTime;
        position.y = Mathf.Sin(Time.time * golfFrequentie) * golfSterkte;
        transform.position = position;





    }
}
