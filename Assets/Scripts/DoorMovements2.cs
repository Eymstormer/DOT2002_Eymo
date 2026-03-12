using UnityEngine;

public class DoorMovements2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door2")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose2");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door2")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose2");
        }
    }
}
