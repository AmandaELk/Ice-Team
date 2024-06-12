using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jacketChangeColour : MonoBehaviour
{
    public Material[] jacketColours;
    public GameObject jacketClothes;
    // Start is called before the first frame update
    void Start()
    {
        ColourChange(1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ColourChange(int colourIndex)
    {
        Debug.Log("colourchangebrr");
        jacketClothes.GetComponent<MeshRenderer>().material = jacketColours[colourIndex];
    }
}
