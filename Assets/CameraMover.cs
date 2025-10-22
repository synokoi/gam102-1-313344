using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed;
    [SerializeField]
    float moveSpeed;
    private void Start()
    {
        
    }
    private void Update()
    {
        float movex = Input.GetAxis("Horizontal");
        float movez = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 move = new Vector3(movex, moveSpeed, movez) * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 back = new Vector3( movex, -moveSpeed, movez) * moveSpeed * Time.deltaTime;
            transform.Translate(back);
        }
    }
}
