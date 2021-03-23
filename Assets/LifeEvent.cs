using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeEvent : MonoBehaviour
{
    public enum Type
    {
        WentToSchool,
        GotAJob
    }
    public Type type;

    void OnTriggerEnter(Collider collider)
    {
        Eulogy eulogy = collider.GetComponent<Eulogy>();
        if (eulogy != null)
        {
            eulogy.Add(type);
        }
    }
}
