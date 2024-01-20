using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionnslidechange : MonoBehaviour
{
    public List<GameObject> slides = new List<GameObject>;
    public int slideno = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(slideno > 0)
            {
                slideno += -1;
                for(i = 0; i<Count(slides); i++)
                {
                    slides[i].SetActive(false);
                }

            }
        }
    }
}
