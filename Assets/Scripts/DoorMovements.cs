using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class DoorMovements : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Door")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("Openclose");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("Openclose");
        }
    }
}
