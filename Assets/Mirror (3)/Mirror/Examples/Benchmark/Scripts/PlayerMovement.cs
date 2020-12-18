using UnityEngine;

namespace Mirror.Examples.OneK
{
    public class PlayerMovement : NetworkBehaviour
    {
        public float speed = 5;
        public CharacterController playerSphere;
        public GameObject playerCamera;
       
        
        // Start is called before the first frame update
        void Start()
        {
            
           
        }
        void Update()
        {
            if (!isLocalPlayer) return;
            if (playerCamera.activeSelf == false)
            {
                playerCamera.SetActive(true);
            }
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 dir = new Vector3(h, 0, v);
            playerSphere.Move(dir * Time.deltaTime * speed);
        }
    }
}
