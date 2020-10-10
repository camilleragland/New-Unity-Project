using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Swimming : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fog = false;
        RenderSettings.fogColor = new Color(0.2f, 0.4f, 0.8f, 0.5f);
        RenderSettings.fogDensity = 0.3f;
         
    }
    bool IsUnderwater()
    {
        return gameObject.transform.position.y < 0;
    }
    // Update is called once per frame
    void Update()
    {
        RenderSettings.fog = IsUnderwater();
    }
}
