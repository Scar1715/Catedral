using UnityEngine;

public class Navegacion : MonoBehaviour
{
      public float rotationSpeed = 100f; 
      public float angleMin ;
      public float angleMax ;
    
        void Update()
        {
           
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0); 

                
                
    
                
                if (touch.phase == TouchPhase.Moved)
                {
                    
                    float rotationX = touch.deltaPosition.x * rotationSpeed * Time.deltaTime;
                    float rotationY = touch.deltaPosition.y * rotationSpeed * Time.deltaTime;
                    
                   
    
                    
                    transform.Rotate(Vector3.right, rotationY, Space.World);
                    transform.Rotate(Vector3.up, rotationX, Space.World);
                    
                    if(transform.eulerAngles.x < angleMin) transform.eulerAngles = new Vector3(angleMin, transform.eulerAngles.y, transform.eulerAngles.x);
                    if(transform.eulerAngles.x > angleMax) transform.eulerAngles = new Vector3(angleMax, transform.eulerAngles.y, transform.eulerAngles.x);
                }
                
                
                
                Debug.Log(transform.eulerAngles.x);
            }
        }
}
