using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedLightSwitch : MonoBehaviour {

    public Material material;
    private int counter = 0;
    private Color[] colors = new Color[] { Color.red, Color.green, Color.cyan, Color.magenta };

    // Use this for initialization
    void Start () {
        InvokeRepeating("ChangeLight", 2.0f, 3.0f);
	}

    private void ChangeLight()
    {

        material.SetColor("_EmissionColor", colors[counter]);
        material.SetColor("_Color", colors[counter]);
        counter++;

        if (counter == colors.Length)
        {
            counter = 0;
        }

    }
}
