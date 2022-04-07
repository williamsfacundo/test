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
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");       
        
        movement.x = h * speed * Time.deltaTime;        
        movement.z = v * speed * Time.deltaTime;

        cc.Move(movement);
    }
}
