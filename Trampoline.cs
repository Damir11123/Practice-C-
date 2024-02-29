using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float JumpFactor = 6f;
   //вход
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= JumpFactor;
    }

    //выход 
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= JumpFactor;
    }
}
