using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject wave;
    public float mingolfFriquenty;
    public float maxgolfFriquenty;
    float time = 0f;
    

 
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 3)
        {
           
            GameObject theWave = Instantiate(wave, transform.position, Quaternion.identity);
            MovementWave waveController = theWave.GetComponent<MovementWave>();
            waveController.golfFrequentie = Random.Range(mingolfFriquenty, maxgolfFriquenty);
            time = 0;
        }

    }
}
