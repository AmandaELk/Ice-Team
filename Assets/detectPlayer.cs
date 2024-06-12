using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectPlayer : MonoBehaviour
{
    public float distanceTrigger;
    private float distance;
    public GameObject mascot;
    public GameObject[] question;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Update()
    {
        distance = Vector3.Distance(mascot.transform.position, Camera.main.transform.position);
        promptQuestion();
    }
    private void promptQuestion()
    {
        if(distance <= distanceTrigger)
        {
            foreach (GameObject ques in question)
            {
                ques.SetActive(true);
            }
        }
        if (distance >= distanceTrigger)
        {
            foreach (GameObject ques in question)
            {
                ques.SetActive(false);
            }
        }
    }
}
