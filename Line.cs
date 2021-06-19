using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
   public float moveSpeed; //Toc do di chuyen
   float xDirection; //Huong di chuyen theo truc X
   


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   //
        xDirection = Input.GetAxisRaw("Horizontal");//(-1;0;1) Khi bam nut sang trai tra ve -1, khi bam sang phai tra ve 1
        moveSpeed = 10; // toc do =10
        float movestep = moveSpeed*xDirection*Time.deltaTime; // moveSpeed*1or0or-1*thoigian1khunghinh
        // thiet lap di chuyen
                                                    //   x      y  z
        if((transform.position.x <= -10.4f && xDirection < 0) || (transform.position.x >= 10.4f && xDirection > 0))
            return;
        //Neu thay doi.toa do.x <= -10.4f va sang trai hoac nguoc lai thi khong lam gi ca
        transform.position = transform.position + new Vector3(movestep, 0, 0); // thay doi toa do doi tuong

        

    }
}
