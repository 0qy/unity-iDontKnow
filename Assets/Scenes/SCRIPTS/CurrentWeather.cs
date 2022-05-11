using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentWeather : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Weather w = APIhelper.GetCurrentWeather();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
