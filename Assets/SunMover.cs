using UnityEngine;
using static UnityEngine.GridBrushBase;
public class GetKeyDown : MonoBehaviour
{
    [SerializeField]
    //to control in editor
    float rotateSpeed;
    [SerializeField]
    Vector3 rotationDirection = new Vector3();
    //blank vector3 to control what direction it rotate
    public Rigidbody rb;
    // Start is called  before first frame
    void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(rotateSpeed * rotationDirection * Time.deltaTime);
        }
    }
}