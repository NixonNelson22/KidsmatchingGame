using UnityEngine;


public class InputManager : MonoBehaviour
{
    public AnimalDatabase animal;
    GameObject SelectedObject;
    public GameObject indicator;

    public Camera camera;
    
    // if mouse clicks and drags on object it picks the object and when clickreleased drops the object
    void Update(){
        LayerMask layerMask = LayerMask.GetMask("animals");
        Vector3 mousePos = Input.mousePosition;
		mousePos.z = camera.nearClipPlane;
        
        Ray ray = camera.ScreenPointToRay(mousePos);
        Debug.DrawRay(mousePos, ray.direction,Color.white);
		RaycastHit hit;
		if(Physics.Raycast(ray,out hit, 100,layerMask))
		{
			SelectedObject = hit.collider.gameObject;
            indicator.transform.position = hit.point;
            Debug.Log(hit.collider.gameObject.name);
		}
		
        

    }
    
}
