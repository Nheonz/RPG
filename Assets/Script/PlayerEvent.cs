using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    PlayerMotion playerMotion;

    private void Awake()
    {
        playerMotion = GetComponentInParent<PlayerMotion>();
    }
    public void Land()
    {
        playerMotion.FallEnd();
    }
}
