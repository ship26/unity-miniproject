using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour

{
    // Start is called before the first frame update


    public Image CursorGageImage;

    private Vector3 ScreenCenter;

    private float GageTimer;

    private Cardboard MagnetButton;



    void Start()
    {


        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);

        MagnetButton = GetComponent<Cardboard>();

    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);

        RaycastHit hit;

        CursorGageImage.fillAmount = GageTimer;

        if(Physics.Raycast(ray, out hit, 100.0f))
        {
            if (hit.collider.CompareTag("Box"))
            {
                GageTimer += 1.0f / 3.0f * Time.deltaTime;

                if (GageTimer >= 1 || MagnetButton.Triggered)
                {

                    hit.transform.gameObject.SetActive(false);

                    GageTimer = 0;
                }

            }
        }
        else
        {
            GageTimer = 0;
        }




    }
}

