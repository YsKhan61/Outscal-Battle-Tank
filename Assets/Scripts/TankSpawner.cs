using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public TankTypes tankType;
        public float movementSpeed;
        public float rotationSpeed;
        public Material color;

    }
    [Space(20)]
    public TankView tankView;
    public List<Tank> TankList;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(TankList[1].movementSpeed, TankList[1].rotationSpeed, TankList[1].tankType, TankList[1].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}