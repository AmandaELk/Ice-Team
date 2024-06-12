using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class clothesAttach : MonoBehaviour
{
    public Transform mannequin;  // The object to snap onto
    public Transform hanger;
    public Vector3 snapOffset;      // Offset if needed
    public float snapDistance = 1.0f;  // Maximum distance to snap
    public float snapSpeed = 5.0f;  // Speed of snapping
    public GameObject[] button;
    //public Vector3 startP
    void Update()
    {
        float manDistance = Vector3.Distance(transform.position, mannequin.position);
        float hanDistance = Vector3.Distance(transform.position, hanger.position);

        if (manDistance <= snapDistance)
        {
            SnapToMannequin();
            foreach (GameObject but in button)
            {
                but.SetActive(true);
            }
        }
        if(manDistance >= snapDistance)
        {
            foreach(GameObject but in button) 
            {
                but.SetActive(false);
            }
                
        }
        if (hanDistance <= snapDistance)
        {
            SnapToHanger();
        }
    }
    
    void SnapToMannequin()
    {
        Vector3 mannequinPosition = mannequin.position + snapOffset;

        transform.position = Vector3.Lerp(transform.position, mannequinPosition, Time.deltaTime * snapSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, mannequin.rotation, Time.deltaTime * snapSpeed);
        // Optionally, adjust rotation if needed using Quaternion.Lerp
        // transform.rotation = Quaternion.Lerp(transform.rotation, targetObject.rotation, Time.deltaTime * snapSpeed);
    }
    void SnapToHanger()
    {
        Vector3 hangerPosition = hanger.position + snapOffset;
        transform.position = Vector3.Lerp(transform.position, hangerPosition, Time.deltaTime * snapSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, hanger.rotation, Time.deltaTime * snapSpeed);
    }
}
