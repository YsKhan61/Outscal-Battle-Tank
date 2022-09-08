
using UnityEngine;

public class TankModel
{
    public float movementSpeed;
    public float rotationSpeed;
    public TankTypes tankType;
    public Material color;

    private TankController tankController;

    public TankModel(float _movementSpeed, float _rotationSpeed, TankTypes _tankType, Material _color)
    {
        movementSpeed = _movementSpeed;
        rotationSpeed = _rotationSpeed;
        tankType = _tankType;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
