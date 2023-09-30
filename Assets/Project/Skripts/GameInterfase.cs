using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInterfase : MonoBehaviour
{
    public Slider intensity;
    public Data data;
    void Start()
    {
        Muwer.rid.sensitivity = intensity.value;
    }
    private void OnEnable()
    {
        if (Muwer.rid)
        {
            Muwer.rid.sensitivity = intensity.value;
        }
    }
    void Update()
    {

    }
}
