using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WaveColor { Red, Green, Blue}

public class WaveColler : MonoBehaviour
{
    public Material blue;
    public WaveColor waveColor = WaveColor.Blue;
  

    void Start()
    {
        waveColor = (WaveColor) Random.Range(0, 3);
        SetColor();
    }

    void SetColor()
    {
        
            switch (waveColor)
            {
                case WaveColor.Blue:
                MeshRenderer meshrenderer = GetComponentInChildren<MeshRenderer>();
                if (meshrenderer != null)
                {
                    meshrenderer.material = blue;
                }
                    break;
            }
        }

    void Update()
    {
        
    }
}
