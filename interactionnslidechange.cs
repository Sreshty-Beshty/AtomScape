using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OpenAI
{
    public class interactionnslidechange : MonoBehaviour
    {
        public List<GameObject> slides = new List<GameObject>();
        public int slideno = 0;
        public int i;
        public List<GameObject> interactables = new List<GameObject>();
        public List<bool> caninteract = new List<bool>();
        public List<string> informationtxt = new List<string>();
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
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
        }
    }
}