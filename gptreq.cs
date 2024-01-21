using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace OpenAI
{
    public class gptreq : MonoBehaviour
    {
        public GameObject GPTMENU;
        public Text gptoutput;
        public OpenAIApi openai = new OpenAIApi();
        public GameObject conveyer;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (GPTMENU.activeSelf)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        private async void SendRequest(string prompt)
        {
            var req = new CreateChatCompletionRequest
            {
                Model = "gpt-3.5-turbo",
                Messages = new List<ChatMessage>()
        {
            new ChatMessage()
            {
                Role = "user",
                Content = prompt
            }
        }
            };
            var res = await openai.CreateChatCompletion(req);
            gptoutput.text = res.Choices[0].Message.Content;

        }
        public void rungptcommand(string a)
        {
            if (conveyer.transform.position.z == 1f)
            {
                a = "Solve for the outputs when" + a + "Include all outputs in a tabular format consist of product name and quantity. Also include all leftover reagents in a similar table. Use standard molar masses for the quantities";
            }
            SendRequest(a);
        }
    }

}
