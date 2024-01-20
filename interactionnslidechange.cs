using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace OpenAI
{
    public class interactionnslidechange : MonoBehaviour
    {
        public List<GameObject> slides = new List<GameObject>();
        public int slideno = 0;
        public int i;
        public int j;
        public List<GameObject> interactables = new List<GameObject>();
        public List<bool> caninteract = new List<bool>();
        public List<string> informationtxt = new List<string>();
        public GameObject informationmenu;
        public Text informationtext;
        public GameObject labCoatStand;

        // Start is called before the first frame update
        void Start()
        {

        }


        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.X)) { }
            informationmenu.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Q))

            {
                if (slideno > 0)
                {
                    slideno += -1;
                    for (i = 0; i < slides.Count; i++)
                    {
                        slides[i].SetActive(false);
                    }
                    slides[slideno].SetActive(true);

                }
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (slideno < slides.Count)
                {
                    slideno += 1;
                    for (i = 0; i < slides.Count; i++)
                    {
                        slides[i].SetActive(false);
                    }
                    slides[slideno].SetActive(true);

                }
            }
            for(j=0; j<interactables.Count; j++)
            {
                if(Vector3.Magnitude(interactables[j].transform.position - transform.position) < 3f)
                {
                    if(Vector3.Dot((interactables[j].transform.position - transform.position).normalized, transform.right) > 0.9f)
                    {
                        if (caninteract[i])
                        {
                            if (Input.GetKeyDown(KeyCode.M))
                            {
                                informationmenu.SetActive(true);
                                informationtext.text = informationtxt[i];
                            }
                            if (Input.GetKeyDown(KeyCode.Z))
                            {if(i == 0)
                                {
                                    interactables[i].SetActive(false);
                                    caninteract[0] = true;
                                    labCoatStand.SetActive(true);
                                    labCoatStand.GetComponentsInChildren<ParticleSystem>().Play();
                                }
                               else if(i == 1)
                                {
                                    //maan hasnt sent teacher yet
                                    caninteract[1] = true;
                                }
                               else if(i == 2)
                                {
                                    interactables[i].SetActive(false);
                                    interactables[3].SetActive(true); 
                                    caninteract[3] = true;
                                     caninteract[2] = false;

                                }
                               else if(i == 3)
                                {
                                    interactables[i].SetActive(false);
                                    
                                    caninteract[9] = true;
                                    caninteract[3] = false;
                                   
                                }
                               else if(i == 4)
                                {
                                    interactables[i].SetActive(false);
                                    interactables[5].SetActive(true); 
                                    caninteract[5] = true;
                                    caninteract[4] = false;
                                }
                               else if(i == 5)
                                {
                                    //action1
                                }
                               else if(i == 6)
                                {
                                    interactables[i].SetActive(false);
                                    interactables[7].SetActive(true); 
                                    caninteract[7] = true;
                                    caninteract[6] = false;
                                }
                               else if(i == 7)
                                {
                                    //action1
                                }
                               else if(i == 8)
                                {
                                    //action1
                                }
                               
                            }
                        }
                    }
                }
            }
        }

    }
}