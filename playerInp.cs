using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playerInp : MonoBehaviour
{
   [Tooltip("ms^-1")]  [SerializeField]   float Speed = 4f;
    [SerializeField] float xRange = 3.5f;
    [SerializeField] float yRange = 2f;

    [SerializeField] float PositionPitchFactor = -5f;
    [SerializeField] float ControlPitchFactor = -5f;

    [SerializeField] float PositionYawFactor = -5f;
    [SerializeField] float ControlYawFactor = -15f;
    [SerializeField] float ControlRollFactor = -15f;
  

    float horizontalFlow , verticalFlow;

    bool isControlEnabled = true;

    void Start()
    {
        
    }

    
    void Update()
    {
      //  if(isControlEnabled == true)
     //   {
        ProcessTranslation();
        ProcessRotation();
     //   }

     
    }


    void    OnDead()
    {
        print("control frez");
        isControlEnabled = false;
        
    }




    private void  ProcessRotation()
    {
        float pitch = transform.localPosition.y * PositionPitchFactor + verticalFlow * ControlPitchFactor;
        float yaw = transform.localPosition.x * PositionYawFactor + horizontalFlow * ControlYawFactor;
        float roll = horizontalFlow * ControlRollFactor;
        transform.localRotation = Quaternion.Euler(pitch,yaw,roll);
      //  print(transform.localEulerAngles);
    }


    private void  ProcessTranslation()
    {
         horizontalFlow = CrossPlatformInputManager.GetAxis("Horizontal");
        float offsetCurrentFramex = horizontalFlow * Speed * Time.deltaTime;
      
        float rawxPos = transform.localPosition.x + offsetCurrentFramex;

        float clampedx = Mathf.Clamp(rawxPos, - xRange, xRange);

        transform.localPosition = new Vector3(clampedx, transform.localPosition.y, transform.localPosition.z);






         verticalFlow = CrossPlatformInputManager.GetAxis("Vertical");
        float offsetCurrentFramey = verticalFlow * Speed * Time.deltaTime;

        float rawyPos = transform.localPosition.y + offsetCurrentFramey;

        float clampedy = Mathf.Clamp(rawyPos, -yRange, yRange);

        transform.localPosition = new Vector3(transform.localPosition.x, clampedy, transform.localPosition.z);

    }

    
    
   

    
}
