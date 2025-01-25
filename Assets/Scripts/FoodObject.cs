using UnityEngine;

public class FoodObject : CellObject
{
    public int foodAmount;

    public override void PlayerEntered()
    {
        Destroy(gameObject);

        //increase food
        Debug.Log("Food increased");

        GameManager.Instance.ChangeFood(foodAmount);

    }
}
