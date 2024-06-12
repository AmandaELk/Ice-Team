using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skirtChangeColour : MonoBehaviour
{
    public Material[] skirtColours;
    public GameObject skirtClothes;
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
        skirtClothes.GetComponent<MeshRenderer>().material = skirtColours[colourIndex];
    }
}
