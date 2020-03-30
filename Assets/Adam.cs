using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adam : MonoBehaviour
{
    // Start is called before the first frame update

    public float hiz, yukselisHizi;
   
    private Vector2 moveVelocity;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(hiz * Time.deltaTime , Input.GetAxisRaw("Vertical") * Time.fixedDeltaTime, 0);
    }

   
}
