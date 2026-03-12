using UnityEngine;
using UnityEngine.InputSystem;

public class SauronEye : MonoBehaviour
{
    public float rotationSpeed = 15f;
    public float zDepth = 10f;

    void Update()
    {
        if (Mouse.current == null || Camera.main == null) return;

        // Mouse pozisyonunu al
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Vector3 screenPos = new Vector3(mousePos.x, mousePos.y, zDepth);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

        // Hedefe bakýþ yönü
        Vector3 targetDir = worldPos - transform.position;

        // Tek satýrda kesin çözüm:
        if (targetDir != Vector3.zero)
        {
            Quaternion lookRot = Quaternion.LookRotation(targetDir);
            // Eðer küre ters duruyorsa buraya * Quaternion.Euler(0, 180, 0) ekleyebilirsin
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, rotationSpeed * Time.deltaTime);
        }
    }
}