using UnityEngine;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{
    private void Update() 
    {
      if (!isLocalPlayer) return;
    }
}
