using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    // Start is called before the first frame update
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
       
    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // there is no kithen object here
            if (player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                // player not carryinh anything
            }
        }
        else
        {
            // there is a kitchen object here
            if (player.HasKitchenObject()) 
            {
                //player is carrying something    
            }
            else
            {
                //player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

}

