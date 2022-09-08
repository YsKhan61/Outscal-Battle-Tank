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
        
    }

    public void CreateTank(TankTypes tankTypes)
    {
        if (tankTypes == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(TankList[0].movementSpeed, TankList[0].rotationSpeed, TankList[0].tankType, TankList[0].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if(tankTypes == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(TankList[1].movementSpeed, TankList[1].rotationSpeed, TankList[1].tankType, TankList[1].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if(tankTypes == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(TankList[2].movementSpeed, TankList[2].rotationSpeed, TankList[2].tankType, TankList[2].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        
    }
}