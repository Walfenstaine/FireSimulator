using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mask : MonoBehaviour
{
    public Image mask;
    public static Mask rid { get; set; }

    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }

    public void EnterSmoke()
    {
        mask.enabled = true;
    }
    public void ExitSmoke()
    {
        mask.enabled = false;
    }
    void Update()
    {
        
    }
}
