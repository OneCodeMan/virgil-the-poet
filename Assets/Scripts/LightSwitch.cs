using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

    public Material material;
    private int counter;
    private bool playerOnSurface = false;
    private Color[] colors = new Color[] { Color.red, Color.green, Color.cyan, Color.magenta };

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerOnSurface)
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Player")
        {
            playerOnSurface = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.tag == "Player")
        {
            playerOnSurface = false;
        }
    }
}
