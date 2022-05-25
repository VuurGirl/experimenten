using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    public GameObject bluepanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        
        WaveColler waveColor = collision.gameObject.GetComponent<WaveColler>();
        if(waveColor != null)
        {
            switch (waveColor.waveColor)
            {
                case WaveColor.Blue:
                    MakeScreenBlue();
                    

                    break;
                case WaveColor.Green:

                    break;

                case WaveColor.Red:

                    break;
            }
        }
    }

    public void MakeScreenBlue()
    {
        bluepanel.SetActive(true);
    }
}
