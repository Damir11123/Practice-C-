using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float JumpFactor = 6f;
   //����
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= JumpFactor;
    }

    //����� 
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= JumpFactor;
    }
}
