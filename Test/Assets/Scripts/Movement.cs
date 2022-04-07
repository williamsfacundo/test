using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private CharacterController cc;
    
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();

        movement = new Vector3();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal_One");
        float v = Input.GetAxisRaw("Vertical_One");       
        
        movement.x = v * speed * Time.deltaTime;        
        movement.z = h * speed * Time.deltaTime;

        cc.Move(movement);
    }
}
