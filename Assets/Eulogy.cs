using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using TMPro;

public class Eulogy : MonoBehaviour
{
    public TextMeshProUGUI text;
    Dictionary<LifeEvent.Type, int> events = new Dictionary<LifeEvent.Type, int>();

    void Start()
    {
        foreach (var eventType in System.Enum.GetValues(typeof(LifeEvent.Type)))
        {
            events[(LifeEvent.Type)eventType] = 0;
        }
    }

    public void Add(LifeEvent.Type eventType)
    {
        events[eventType]++;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StringBuilder eulogy = new StringBuilder();
            if (events[LifeEvent.Type.WentToSchool] > 0)
            {
                eulogy.AppendLine($"Went to school");
            }

            int jobs = events[LifeEvent.Type.GotAJob];
            if (jobs > 0)
            {
                eulogy.AppendLine($"Got {jobs} jobs");
            }

            text.enabled = true;
            text.text = eulogy.ToString();
        }
    }
}
