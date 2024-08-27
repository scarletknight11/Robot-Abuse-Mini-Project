using UnityEngine;
using TMPro;

public class Dragging : MonoBehaviour
{
    public float dragSpeed = 1f;
    public GameObject leftArm;
    public GameObject leftArmMessage;
    public Transform shoulder; // Reference to the shoulder transform
    bool isArmDetached = false;
    Vector3 lastMousePos;
    [SerializeField] TMP_Text m_Text;

    void Start()
    {
        UpdateMessageText(); // Call method to update message text initially
        leftArmMessage.SetActive(false);
    }

    void UpdateMessageText()
    {
        m_Text.text = isArmDetached ? "Left Arm Detached" : "Left Arm Attached";
    }

    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
        leftArmMessage.SetActive(true);
    }

    void OnMouseDrag()
    {
        if (isArmDetached)
        {
            Vector3 delta = Input.mousePosition - lastMousePos;
            Vector3 newPos = transform.position + new Vector3(delta.x, delta.y, 0f) * dragSpeed;
            transform.position = newPos;
            lastMousePos = Input.mousePosition;
        }   else
        {
            Vector3 delta = Input.mousePosition - lastMousePos;
            Vector3 pos = transform.position;
            pos.y += delta.y * dragSpeed;
            transform.position = pos;
            lastMousePos = Input.mousePosition;

            Vector3 pos2 = transform.position;
            pos2.x += delta.x * dragSpeed;
            transform.position = pos2;
            lastMousePos = Input.mousePosition;

            leftArmMessage.gameObject.SetActive(true);
            m_Text.text = "Left Arm De-Attached";
            leftArm.transform.SetParent(null);
        }
    }

    void OnMouseUp()
    {
        // Check for collision with the shoulder when mouse is released
        if (!isArmDetached && Vector3.Distance(transform.position, shoulder.position) < 2f) // Adjust the distance as needed
        {
            ReattachArm();
        }
        else
        {
            DetachArm();
        }
    }

    void DetachArm()
    {
        isArmDetached = true;
        UpdateMessageText(); // Update message text when arm is detached
        leftArm.transform.SetParent(null);
    }

    void ReattachArm()
    {
        isArmDetached = false;
        UpdateMessageText(); // Update message text when arm is reattached
        leftArm.transform.SetParent(shoulder);
    }
}
