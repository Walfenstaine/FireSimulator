using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stwol : MonoBehaviour
{
    public ParticleSystem ps;
    public List<Fire> others;
    public static Stwol rid { get; set; }
    private bool wt;
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

    public void WatterSize(bool enable)
    {
        wt = enable;
        if (enable)
        {
            ps.Play();
        }
        else
        {
            ps.Stop();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fire")
        {
            others.Add(other.GetComponent<Fire>());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Fire")
        {
            others.Remove(other.GetComponent<Fire>());
        }
    }
    private void Update()
    {
        if (wt)
        {
            for (int i = 0; i < others.Count; i++)
            {
                others[i].helse -= Time.deltaTime;
            }
        }
    }
}
