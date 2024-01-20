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
        public ParticleSystem ps;
        public int interacts;
        public ParticleSystem ps1;
        public ParticleSystem ps2;
        public ParticleSystem ps3;
        public bool notclicked;
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
                    if(slideno == 0)
                    {
                        caninteract[0] = true;
                        caninteract[1] = true;
                    }
                    if(slideno == 4)
                    {
                        interactables[2].SetActive(true);
                        caninteract[2] = true;
                    }
                    if (slideno == 5)
                    {
                        interactables[4].SetActive(true);
                        caninteract[4] = true;
                    }
                    if (slideno == 6)
                    {
                        interactables[6].SetActive(true);
                        caninteract[6] = true;
                    }
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
                    if (slideno == 0)
                    {
                        caninteract[0] = true;
                        caninteract[1] = true;
                    }
                    if (slideno == 4)
                    {
                        interactables[2].SetActive(true);
                        caninteract[2] = true;
                    }
                    if (slideno == 5)
                    {
                        interactables[4].SetActive(true);
                        caninteract[4] = true;
                    }
                    if (slideno == 6)
                    {
                        interactables[6].SetActive(true);
                        caninteract[6] = true;
                    }
                }
            }
            for(j=0; j<interactables.Count; j++)
            {
                if(Vector3.Magnitude(interactables[j].transform.position - transform.position) < 3f)
                {
                    if(Vector3.Dot((interactables[j].transform.position - transform.position).normalized, transform.right) > 0.9f)
                    {
                        if (caninteract[j])
                        {
                            Debug.Log(j);
                            if (Input.GetKeyDown(KeyCode.M))
                            {
                                informationmenu.SetActive(true);
                                informationtext.text = informationtxt[i];
                            }
                            if (Input.GetKeyDown(KeyCode.Z) && notclicked)
                            {if(j == 0)
                                {
                                    interactables[j].SetActive(false);
                                    caninteract[0] = false;
                                    labCoatStand.SetActive(true);
                                    ps.Play();
                                }
                               else if(j == 1)
                                {
                                    //maan hasnt sent teacher yet
                                    ps.Play();
                                }
                               else if(j == 2)
                                {
                                    interactables[j].SetActive(false);
                                    interactables[3].SetActive(true); 
                                    caninteract[3] = true;
                                    caninteract[2] = false;
                                    ps.Play();
                                }
                               else if(j == 3)
                                {
                                    interactables[j].SetActive(false);
                                    
                                    caninteract[9] = true;
                                    caninteract[3] = false;
                                    ps.Play();

                                }
                               else if(j == 4)
                                {
                                    interactables[j].SetActive(false);
                                    interactables[5].SetActive(true); 
                                    caninteract[5] = true;
                                    caninteract[4] = false;
                                    ps.Play();
                                }
                               else if(j == 5)
                                {
                                    interactables[j].SetActive(false);

                                    caninteract[9] = true;
                                    caninteract[5] = false;
                                    ps.Play();
                                }
                               else if(j == 6)
                                {
                                    interactables[j].SetActive(false);
                                    interactables[7].SetActive(true); 
                                    caninteract[7] = true;
                                    caninteract[6] = false;
                                    ps.Play();
                                }
                               else if(j == 7)
                                {
                                    interactables[j].SetActive(false);

                                    caninteract[9] = true;
                                    caninteract[7] = false;
                                    ps.Play();
                                }
                               else if(j == 8)
                                {
                                    ps.Play();
                                }
                               else if (j == 9)
                                {
                                    interacts += 1;
                                    ps.Play();
                                    if (interacts == 1)
                                    {
                                        ps1.Play();
                                    }
                                    else if (interacts == 2)
                                    {
                                        ps2.Play();
                                    }
                                    else if (interacts == 3)
                                    {
                                        ps3.Play();
                                    }
                                    informationtxt[j] = "Initially Water (H2O), slightly basic, alkeli solution PH > 7.";
                                }
                                notclicked = false;
                            }
                            else
                            {
                                notclicked = true;
                            }
                        }
                    }
                }
            }
        }

    }
}