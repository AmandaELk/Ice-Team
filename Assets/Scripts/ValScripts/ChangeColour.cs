using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public Material[] colours;
    public GameObject shirtClothes;
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
        shirtClothes.GetComponent<MeshRenderer>().material = colours[colourIndex];
    }

}
