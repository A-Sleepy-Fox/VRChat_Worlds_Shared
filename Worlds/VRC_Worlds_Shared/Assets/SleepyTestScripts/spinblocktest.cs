
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class spinblocktest : UdonSharpBehaviour
{
    private bool spin = false;

    private void Update()
    {
        if(spin)
            gameObject.transform.rotation = transform.rotation * new Quaternion(2 * Time.time, 2 * Time.time, 1 * Time.time, 1);
    }

    public override void Interact()
    {
        spin = !spin;
    }
} 
