using UnityEngine;

public class DesableCeillings : MonoBehaviour
{
    private Camera camera;

    private RaycastHit[] infodeColision;

    private void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(camera.transform.position, camera.transform.position.normalized);

        infodeColision = Physics.RaycastAll(camera.transform.position, camera.transform.position.normalized);


        infodeColision[0].GetType();

        if (Physics.Raycast(camera.transform.position, camera.transform.position.normalized, out infodeColision)) 
        {
            if (infodeColision[0].transform.name == "ceiling") 
            {
                
            }
        }    
    }
}
