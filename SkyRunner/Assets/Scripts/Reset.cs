using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private TrollCounter _trollCounter;

    private void Start()
    {
        _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
    }

    public void Click()
    {
        _trollCounter.countTrollNow = 0;
        _trollCounter.trollPerClick = 1;
        _trollCounter.trollPerSecond = 0;
        _trollCounter.level = 1;
    }
}
